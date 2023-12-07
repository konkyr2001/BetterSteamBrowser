﻿using BetterSteamBrowser.Business.Mediatr.Commands;
using BetterSteamBrowser.Business.ViewModels;
using BetterSteamBrowser.Domain.Interfaces.Repositories.Pagination;
using BetterSteamBrowser.Domain.ValueObjects.Pagination;
using BetterSteamBrowser.Infrastructure.Context;
using BetterSteamBrowser.Infrastructure.Utilities;
using Microsoft.EntityFrameworkCore;

namespace BetterSteamBrowser.Infrastructure.Repositories.Pagination;

public class ServersPaginationQueryHelper(IDbContextFactory<DataContext> contextFactory)
    : IResourceQueryHelper<GetServerListCommand, Server>
{
    public async Task<PaginationContext<Server>> QueryResourceAsync(GetServerListCommand request,
        CancellationToken cancellationToken)
    {
        var serverFavourites = new Dictionary<string, bool>();
        await using var context = await contextFactory.CreateDbContextAsync(cancellationToken);
        var query = context.Servers
            .AsNoTracking()
            .Where(x => !x.Blocked)
            .Where(server => server.LastUpdated > DateTimeOffset.UtcNow.AddDays(-1))
            .AsQueryable();

        int? gameSearch = request.Data is int game ? game : null;
        if (gameSearch is not null) query = query.Where(server => server.SteamGame.AppId == gameSearch);

        if (!string.IsNullOrWhiteSpace(request.SearchString))
            query = query.Where(search =>
                (search.Country != null && EF.Functions.ILike(search.Country, $"%{request.SearchString}%")) ||
                EF.Functions.ILike(search.IpAddress, $"%{request.SearchString}%") ||
                EF.Functions.ILike(search.Name, $"%{request.SearchString}%"));

        if (request.Sorts.Any())
            query = request.Sorts.Aggregate(query, (current, sort) => sort.Property switch
            {
                "Name" => current.ApplySort(sort, p => p.Name),
                "Players" => current.ApplySort(sort, p => p.Players),
                "LastUpdated" => current.ApplySort(sort, p => p.LastUpdated),
                _ => current
            });

        if (request.Favourites && !string.IsNullOrWhiteSpace(request.UserId))
        {
            query = query
                .Join(context.Favourites,
                    server => server.Hash,
                    favourite => favourite.ServerId,
                    (server, favourite) => new {Server = server, Favourite = favourite})
                .Where(x => x.Favourite.UserId == request.UserId)
                .Select(x => x.Server);

            serverFavourites = await query
                .Select(server => new
                {
                    server.Hash,
                    IsFavourite = request.Favourites
                })
                .ToDictionaryAsync(t => t.Hash, t => t.IsFavourite, cancellationToken);
        }

        var count = await query.CountAsync(cancellationToken: cancellationToken);
        var playerCount = 0;
        if (gameSearch is not null)
            playerCount = await query.SumAsync(server => server.Players, cancellationToken: cancellationToken);

        var pagedData = await query
            .Skip(request.Skip)
            .Take(request.Top)
            .Select(server => new Server
            {
                IpAddress = server.IpAddress,
                Port = server.Port,
                Name = server.Name,
                SteamGameAppId = server.SteamGame.AppId,
                SteamGameName = server.SteamGame.Name,
                SteamGameId = server.SteamGameId,
                Map = server.Map,
                Players = server.Players,
                MaxPlayers = server.MaxPlayers,
                Country = server.Country ?? "Unknown",
                LastUpdated = server.LastUpdated,
                Favourite = serverFavourites.ContainsKey(server.Hash) && serverFavourites[server.Hash]
            })
            .ToListAsync(cancellationToken: cancellationToken);

        return new PaginationContext<Server>
        {
            Data = pagedData,
            Count = count,
            Players = playerCount
        };
    }
}

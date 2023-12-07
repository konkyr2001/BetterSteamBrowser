﻿using BetterSteamBrowser.Business.Mediatr.Events;
using BetterSteamBrowser.Business.ViewModels;
using MediatR;
using Microsoft.AspNetCore.Components;
using Radzen;

namespace BetterSteamBrowser.WebCore.Components.Pages.Manage.Dialogs;

public partial class RemoveGameDialog
{
    [Parameter] public required SteamGame SteamGame { get; set; }
    [Parameter] public required string UserId { get; set; }
    [Inject] private NotificationService NotificationService { get; set; }
    [Inject] private DialogService DialogService { get; set; }
    [Inject] private IMediator Mediator { get; set; }

    private bool _processing;

    private async Task RemoveSteamGameAsync()
    {
        if (string.IsNullOrWhiteSpace(UserId)) return;
        _processing = true;
        await Mediator.Publish(new RemoveSteamGameCommand {Id = SteamGame.Id});
        NotificationService.Notify(NotificationSeverity.Success, "Game removed!");
        _processing = false;
        DialogService.Close();
    }
}

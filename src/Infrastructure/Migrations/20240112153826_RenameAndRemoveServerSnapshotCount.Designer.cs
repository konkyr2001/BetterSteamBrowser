﻿// <auto-generated />
using System;
using BetterSteamBrowser.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BetterSteamBrowser.Infrastructure.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240112153826_RenameAndRemoveServerSnapshotCount")]
    partial class RenameAndRemoveServerSnapshotCount
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("BetterSteamBrowser.Domain.Entities.EFBlock", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTimeOffset>("Added")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("ApiFilter")
                        .HasColumnType("boolean");

                    b.Property<int>("SteamGameId")
                        .HasColumnType("integer");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("SteamGameId");

                    b.ToTable("EFBlocks", (string)null);

                    b.HasData(
                        new
                        {
                            Id = -1,
                            Added = new DateTimeOffset(new DateTime(2024, 1, 12, 15, 38, 26, 364, DateTimeKind.Unspecified).AddTicks(5216), new TimeSpan(0, 0, 0, 0, 0)),
                            ApiFilter = false,
                            SteamGameId = -2,
                            Type = 2,
                            UserId = "ADMIN_SEED_ID",
                            Value = "FASTCUP"
                        },
                        new
                        {
                            Id = -2,
                            Added = new DateTimeOffset(new DateTime(2024, 1, 12, 15, 38, 26, 364, DateTimeKind.Unspecified).AddTicks(5221), new TimeSpan(0, 0, 0, 0, 0)),
                            ApiFilter = true,
                            SteamGameId = 730,
                            Type = 1,
                            UserId = "ADMIN_SEED_ID",
                            Value = "uwujka"
                        },
                        new
                        {
                            Id = -3,
                            Added = new DateTimeOffset(new DateTime(2024, 1, 12, 15, 38, 26, 364, DateTimeKind.Unspecified).AddTicks(5222), new TimeSpan(0, 0, 0, 0, 0)),
                            ApiFilter = true,
                            SteamGameId = -2,
                            Type = 1,
                            UserId = "ADMIN_SEED_ID",
                            Value = "nosteam"
                        },
                        new
                        {
                            Id = -4,
                            Added = new DateTimeOffset(new DateTime(2024, 1, 12, 15, 38, 26, 364, DateTimeKind.Unspecified).AddTicks(5223), new TimeSpan(0, 0, 0, 0, 0)),
                            ApiFilter = true,
                            SteamGameId = -2,
                            Type = 1,
                            UserId = "ADMIN_SEED_ID",
                            Value = "no-steam"
                        },
                        new
                        {
                            Id = -5,
                            Added = new DateTimeOffset(new DateTime(2024, 1, 12, 15, 38, 26, 364, DateTimeKind.Unspecified).AddTicks(5224), new TimeSpan(0, 0, 0, 0, 0)),
                            ApiFilter = false,
                            SteamGameId = -2,
                            Type = 2,
                            UserId = "ADMIN_SEED_ID",
                            Value = "Develop"
                        },
                        new
                        {
                            Id = -6,
                            Added = new DateTimeOffset(new DateTime(2024, 1, 12, 15, 38, 26, 364, DateTimeKind.Unspecified).AddTicks(5225), new TimeSpan(0, 0, 0, 0, 0)),
                            ApiFilter = false,
                            SteamGameId = -2,
                            Type = 2,
                            UserId = "ADMIN_SEED_ID",
                            Value = "FACEIT"
                        },
                        new
                        {
                            Id = -7,
                            Added = new DateTimeOffset(new DateTime(2024, 1, 12, 15, 38, 26, 364, DateTimeKind.Unspecified).AddTicks(5226), new TimeSpan(0, 0, 0, 0, 0)),
                            ApiFilter = false,
                            SteamGameId = 730,
                            Type = 3,
                            UserId = "ADMIN_SEED_ID",
                            Value = "RU"
                        },
                        new
                        {
                            Id = -8,
                            Added = new DateTimeOffset(new DateTime(2024, 1, 12, 15, 38, 26, 364, DateTimeKind.Unspecified).AddTicks(5227), new TimeSpan(0, 0, 0, 0, 0)),
                            ApiFilter = false,
                            SteamGameId = 252490,
                            Type = 3,
                            UserId = "ADMIN_SEED_ID",
                            Value = "RU"
                        },
                        new
                        {
                            Id = -9,
                            Added = new DateTimeOffset(new DateTime(2024, 1, 12, 15, 38, 26, 364, DateTimeKind.Unspecified).AddTicks(5228), new TimeSpan(0, 0, 0, 0, 0)),
                            ApiFilter = false,
                            SteamGameId = 730,
                            Type = 2,
                            UserId = "ADMIN_SEED_ID",
                            Value = "Counter-Strike 2"
                        });
                });

            modelBuilder.Entity("BetterSteamBrowser.Domain.Entities.EFFavourite", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ServerId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ServerId");

                    b.HasIndex("UserId");

                    b.ToTable("EFFavourites", (string)null);
                });

            modelBuilder.Entity("BetterSteamBrowser.Domain.Entities.EFServer", b =>
                {
                    b.Property<string>("Hash")
                        .HasColumnType("text");

                    b.Property<bool>("Blocked")
                        .HasColumnType("boolean");

                    b.Property<string>("Country")
                        .HasColumnType("text");

                    b.Property<string>("CountryCode")
                        .HasColumnType("text");

                    b.Property<DateTimeOffset>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("IpAddress")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTimeOffset>("LastUpdated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Map")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("MaxPlayers")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double?>("PlayerAverage")
                        .HasColumnType("double precision");

                    b.Property<int?>("PlayerLowerBound")
                        .HasColumnType("integer");

                    b.Property<int?>("PlayerUpperBound")
                        .HasColumnType("integer");

                    b.Property<int>("Players")
                        .HasColumnType("integer");

                    b.Property<double?>("PlayersStandardDeviation")
                        .HasColumnType("double precision");

                    b.Property<int>("Port")
                        .HasColumnType("integer");

                    b.Property<int>("SteamGameId")
                        .HasColumnType("integer");

                    b.HasKey("Hash");

                    b.HasIndex("IpAddress");

                    b.HasIndex("Map");

                    b.HasIndex("Name");

                    b.HasIndex("SteamGameId");

                    b.ToTable("EFServers", (string)null);
                });

            modelBuilder.Entity("BetterSteamBrowser.Domain.Entities.EFServerSnapshot", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("PlayerCount")
                        .HasColumnType("integer");

                    b.Property<string>("ServerHash")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTimeOffset>("Taken")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("ServerHash");

                    b.ToTable("EFServerSnapshots", (string)null);
                });

            modelBuilder.Entity("BetterSteamBrowser.Domain.Entities.EFSnapshot", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Count")
                        .HasColumnType("integer");

                    b.Property<int>("Snapshot")
                        .HasColumnType("integer");

                    b.Property<DateTimeOffset>("Stored")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("EFSnapshots", (string)null);
                });

            modelBuilder.Entity("BetterSteamBrowser.Domain.Entities.EFSteamGame", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("EFSteamGames", (string)null);

                    b.HasData(
                        new
                        {
                            Id = -2,
                            Name = "All Games"
                        },
                        new
                        {
                            Id = -1,
                            Name = "Unknown"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Counter-Strike"
                        },
                        new
                        {
                            Id = 30,
                            Name = "Day of Defeat"
                        },
                        new
                        {
                            Id = 50,
                            Name = "Half-Life: Opposing Force"
                        },
                        new
                        {
                            Id = 70,
                            Name = "Half-Life"
                        },
                        new
                        {
                            Id = 80,
                            Name = "Condition Zero"
                        },
                        new
                        {
                            Id = 240,
                            Name = "Counter-Strike: Source"
                        },
                        new
                        {
                            Id = 300,
                            Name = "Day of Defeat: Source"
                        },
                        new
                        {
                            Id = 320,
                            Name = "Half-Life 2: Deathmatch"
                        },
                        new
                        {
                            Id = 440,
                            Name = "Team Fortress 2"
                        },
                        new
                        {
                            Id = 500,
                            Name = "Left 4 Dead"
                        },
                        new
                        {
                            Id = 550,
                            Name = "Left 4 Dead 2"
                        },
                        new
                        {
                            Id = 730,
                            Name = "Counter-Strike 2"
                        },
                        new
                        {
                            Id = 1250,
                            Name = "Killing Floor"
                        },
                        new
                        {
                            Id = 4000,
                            Name = "Garry's Mod"
                        },
                        new
                        {
                            Id = 17520,
                            Name = "Synergy"
                        },
                        new
                        {
                            Id = 33930,
                            Name = "Arma 2: Operation Arrowhead"
                        },
                        new
                        {
                            Id = 107410,
                            Name = "Arma 3"
                        },
                        new
                        {
                            Id = 108600,
                            Name = "Project Zomboid"
                        },
                        new
                        {
                            Id = 221100,
                            Name = "DayZ"
                        },
                        new
                        {
                            Id = 222880,
                            Name = "Insurgency"
                        },
                        new
                        {
                            Id = 242760,
                            Name = "The Forest"
                        },
                        new
                        {
                            Id = 251570,
                            Name = "7 Days to Die"
                        },
                        new
                        {
                            Id = 252490,
                            Name = "Rust"
                        },
                        new
                        {
                            Id = 304930,
                            Name = "Unturned"
                        },
                        new
                        {
                            Id = 312660,
                            Name = "Sniper Elite 4"
                        },
                        new
                        {
                            Id = 393380,
                            Name = "Squad"
                        },
                        new
                        {
                            Id = 394690,
                            Name = "Tower Unite"
                        },
                        new
                        {
                            Id = 632360,
                            Name = "Risk of Rain 2"
                        },
                        new
                        {
                            Id = 686810,
                            Name = "Hell Let Loose"
                        },
                        new
                        {
                            Id = 1604030,
                            Name = "V Rising"
                        },
                        new
                        {
                            Id = 346110,
                            Name = "ARK: Survival Evolved"
                        });
                });

            modelBuilder.Entity("BetterSteamBrowser.Infrastructure.Identity.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "ADMIN_SEED_ID",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "8d46299a-8777-471c-9c41-da8d492d7485",
                            Email = "superadmin@example.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "SUPERADMIN@EXAMPLE.COM",
                            NormalizedUserName = "SUPERADMIN",
                            PasswordHash = "AQAAAAIAAYagAAAAEKgOt3nYjQGJUN16HTEuRfn2UZM84oSykri/aJMmgEtNRwL0QlhEpDnn0Ymcil76Gw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "SuperAdmin"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "610e2452-1996-46e8-b93f-9d5a1d8bdf9b",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "ADMIN_SEED_ID",
                            RoleId = "610e2452-1996-46e8-b93f-9d5a1d8bdf9b"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("BetterSteamBrowser.Domain.Entities.EFBlock", b =>
                {
                    b.HasOne("BetterSteamBrowser.Domain.Entities.EFSteamGame", "SteamGame")
                        .WithMany()
                        .HasForeignKey("SteamGameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SteamGame");
                });

            modelBuilder.Entity("BetterSteamBrowser.Domain.Entities.EFFavourite", b =>
                {
                    b.HasOne("BetterSteamBrowser.Domain.Entities.EFServer", "Server")
                        .WithMany()
                        .HasForeignKey("ServerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BetterSteamBrowser.Infrastructure.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Server");
                });

            modelBuilder.Entity("BetterSteamBrowser.Domain.Entities.EFServer", b =>
                {
                    b.HasOne("BetterSteamBrowser.Domain.Entities.EFSteamGame", "SteamGame")
                        .WithMany()
                        .HasForeignKey("SteamGameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SteamGame");
                });

            modelBuilder.Entity("BetterSteamBrowser.Domain.Entities.EFServerSnapshot", b =>
                {
                    b.HasOne("BetterSteamBrowser.Domain.Entities.EFServer", "Server")
                        .WithMany("Snapshots")
                        .HasForeignKey("ServerHash")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Server");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("BetterSteamBrowser.Infrastructure.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("BetterSteamBrowser.Infrastructure.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BetterSteamBrowser.Infrastructure.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("BetterSteamBrowser.Infrastructure.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BetterSteamBrowser.Domain.Entities.EFServer", b =>
                {
                    b.Navigation("Snapshots");
                });
#pragma warning restore 612, 618
        }
    }
}

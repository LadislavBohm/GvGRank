﻿// <auto-generated />
using System;
using GvGRank_Server.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GvGRank_Server.Migrations
{
    [DbContext(typeof(VoteDbContext))]
    [Migration("20190809212641_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GvGRank_Server.Models.IP", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ip")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.HasKey("Id");

                    b.ToTable("IPs");
                });

            modelBuilder.Entity("GvGRank_Server.Models.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Losses");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<int>("Shitlo");

                    b.Property<int>("Wins");

                    b.HasKey("Id");

                    b.ToTable("Players");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Losses = 0,
                            Name = "Aspect",
                            Shitlo = 0,
                            Wins = 0
                        },
                        new
                        {
                            Id = 2,
                            Losses = 0,
                            Name = "Lynie",
                            Shitlo = 0,
                            Wins = 0
                        },
                        new
                        {
                            Id = 3,
                            Losses = 0,
                            Name = "Vesto",
                            Shitlo = 0,
                            Wins = 0
                        },
                        new
                        {
                            Id = 4,
                            Losses = 0,
                            Name = "Maverick",
                            Shitlo = 0,
                            Wins = 0
                        },
                        new
                        {
                            Id = 5,
                            Losses = 0,
                            Name = "Purif",
                            Shitlo = 0,
                            Wins = 0
                        },
                        new
                        {
                            Id = 6,
                            Losses = 0,
                            Name = "Willy",
                            Shitlo = 0,
                            Wins = 0
                        },
                        new
                        {
                            Id = 7,
                            Losses = 0,
                            Name = "Sam",
                            Shitlo = 0,
                            Wins = 0
                        },
                        new
                        {
                            Id = 8,
                            Losses = 0,
                            Name = "Ice",
                            Shitlo = 0,
                            Wins = 0
                        },
                        new
                        {
                            Id = 9,
                            Losses = 0,
                            Name = "Oln",
                            Shitlo = 0,
                            Wins = 0
                        },
                        new
                        {
                            Id = 10,
                            Losses = 0,
                            Name = "Fluxy",
                            Shitlo = 0,
                            Wins = 0
                        },
                        new
                        {
                            Id = 11,
                            Losses = 0,
                            Name = "Takida",
                            Shitlo = 0,
                            Wins = 0
                        },
                        new
                        {
                            Id = 12,
                            Losses = 0,
                            Name = "Butters",
                            Shitlo = 0,
                            Wins = 0
                        },
                        new
                        {
                            Id = 13,
                            Losses = 0,
                            Name = "Dopos",
                            Shitlo = 0,
                            Wins = 0
                        },
                        new
                        {
                            Id = 14,
                            Losses = 0,
                            Name = "Yoko",
                            Shitlo = 0,
                            Wins = 0
                        },
                        new
                        {
                            Id = 15,
                            Losses = 0,
                            Name = "Candyboy",
                            Shitlo = 0,
                            Wins = 0
                        },
                        new
                        {
                            Id = 16,
                            Losses = 0,
                            Name = "Rainy",
                            Shitlo = 0,
                            Wins = 0
                        },
                        new
                        {
                            Id = 17,
                            Losses = 0,
                            Name = "Akemi",
                            Shitlo = 0,
                            Wins = 0
                        },
                        new
                        {
                            Id = 18,
                            Losses = 0,
                            Name = "Lisek",
                            Shitlo = 0,
                            Wins = 0
                        },
                        new
                        {
                            Id = 19,
                            Losses = 0,
                            Name = "Kay",
                            Shitlo = 0,
                            Wins = 0
                        },
                        new
                        {
                            Id = 20,
                            Losses = 0,
                            Name = "Sven",
                            Shitlo = 0,
                            Wins = 0
                        },
                        new
                        {
                            Id = 21,
                            Losses = 0,
                            Name = "Teddy",
                            Shitlo = 0,
                            Wins = 0
                        },
                        new
                        {
                            Id = 22,
                            Losses = 0,
                            Name = "Brent",
                            Shitlo = 0,
                            Wins = 0
                        },
                        new
                        {
                            Id = 23,
                            Losses = 0,
                            Name = "Ali",
                            Shitlo = 0,
                            Wins = 0
                        },
                        new
                        {
                            Id = 24,
                            Losses = 0,
                            Name = "Kasperov",
                            Shitlo = 0,
                            Wins = 0
                        },
                        new
                        {
                            Id = 25,
                            Losses = 0,
                            Name = "Holye",
                            Shitlo = 0,
                            Wins = 0
                        },
                        new
                        {
                            Id = 26,
                            Losses = 0,
                            Name = "Nihal",
                            Shitlo = 0,
                            Wins = 0
                        },
                        new
                        {
                            Id = 27,
                            Losses = 0,
                            Name = "Yamamoto",
                            Shitlo = 0,
                            Wins = 0
                        },
                        new
                        {
                            Id = 28,
                            Losses = 0,
                            Name = "Motoko",
                            Shitlo = 0,
                            Wins = 0
                        },
                        new
                        {
                            Id = 29,
                            Losses = 0,
                            Name = "Chunin",
                            Shitlo = 0,
                            Wins = 0
                        },
                        new
                        {
                            Id = 30,
                            Losses = 0,
                            Name = "Newty",
                            Shitlo = 0,
                            Wins = 0
                        },
                        new
                        {
                            Id = 31,
                            Losses = 0,
                            Name = "Zynkh",
                            Shitlo = 0,
                            Wins = 0
                        },
                        new
                        {
                            Id = 32,
                            Losses = 0,
                            Name = "Honk",
                            Shitlo = 0,
                            Wins = 0
                        },
                        new
                        {
                            Id = 33,
                            Losses = 0,
                            Name = "Sebbe",
                            Shitlo = 0,
                            Wins = 0
                        },
                        new
                        {
                            Id = 34,
                            Losses = 0,
                            Name = "Fate",
                            Shitlo = 0,
                            Wins = 0
                        },
                        new
                        {
                            Id = 35,
                            Losses = 0,
                            Name = "Lao",
                            Shitlo = 0,
                            Wins = 0
                        },
                        new
                        {
                            Id = 36,
                            Losses = 0,
                            Name = "Messy",
                            Shitlo = 0,
                            Wins = 0
                        },
                        new
                        {
                            Id = 37,
                            Losses = 0,
                            Name = "Spartan",
                            Shitlo = 0,
                            Wins = 0
                        },
                        new
                        {
                            Id = 38,
                            Losses = 0,
                            Name = "Chamalee",
                            Shitlo = 0,
                            Wins = 0
                        },
                        new
                        {
                            Id = 39,
                            Losses = 0,
                            Name = "Maga",
                            Shitlo = 0,
                            Wins = 0
                        },
                        new
                        {
                            Id = 40,
                            Losses = 0,
                            Name = "Lua Kavanuh",
                            Shitlo = 0,
                            Wins = 0
                        },
                        new
                        {
                            Id = 41,
                            Losses = 0,
                            Name = "Izzy",
                            Shitlo = 0,
                            Wins = 0
                        },
                        new
                        {
                            Id = 42,
                            Losses = 0,
                            Name = "Remede",
                            Shitlo = 0,
                            Wins = 0
                        },
                        new
                        {
                            Id = 43,
                            Losses = 0,
                            Name = "Pally",
                            Shitlo = 0,
                            Wins = 0
                        },
                        new
                        {
                            Id = 44,
                            Losses = 0,
                            Name = "Jonas",
                            Shitlo = 0,
                            Wins = 0
                        },
                        new
                        {
                            Id = 45,
                            Losses = 0,
                            Name = "Eraziel",
                            Shitlo = 0,
                            Wins = 0
                        },
                        new
                        {
                            Id = 46,
                            Losses = 0,
                            Name = "Santana",
                            Shitlo = 0,
                            Wins = 0
                        },
                        new
                        {
                            Id = 47,
                            Losses = 0,
                            Name = "Yoshi",
                            Shitlo = 0,
                            Wins = 0
                        },
                        new
                        {
                            Id = 48,
                            Losses = 0,
                            Name = "Rudi",
                            Shitlo = 0,
                            Wins = 0
                        },
                        new
                        {
                            Id = 49,
                            Losses = 0,
                            Name = "Nick",
                            Shitlo = 0,
                            Wins = 0
                        },
                        new
                        {
                            Id = 50,
                            Losses = 0,
                            Name = "Mario",
                            Shitlo = 0,
                            Wins = 0
                        },
                        new
                        {
                            Id = 51,
                            Losses = 0,
                            Name = "Math",
                            Shitlo = 0,
                            Wins = 0
                        },
                        new
                        {
                            Id = 52,
                            Losses = 0,
                            Name = "Hemo",
                            Shitlo = 0,
                            Wins = 0
                        },
                        new
                        {
                            Id = 53,
                            Losses = 0,
                            Name = "Hash",
                            Shitlo = 0,
                            Wins = 0
                        },
                        new
                        {
                            Id = 54,
                            Losses = 0,
                            Name = "Miru",
                            Shitlo = 0,
                            Wins = 0
                        },
                        new
                        {
                            Id = 55,
                            Losses = 0,
                            Name = "Sync",
                            Shitlo = 0,
                            Wins = 0
                        },
                        new
                        {
                            Id = 56,
                            Losses = 0,
                            Name = "Moo",
                            Shitlo = 0,
                            Wins = 0
                        },
                        new
                        {
                            Id = 57,
                            Losses = 0,
                            Name = "Bounty",
                            Shitlo = 0,
                            Wins = 0
                        },
                        new
                        {
                            Id = 58,
                            Losses = 0,
                            Name = "Tequila",
                            Shitlo = 0,
                            Wins = 0
                        },
                        new
                        {
                            Id = 59,
                            Losses = 0,
                            Name = "Resi",
                            Shitlo = 0,
                            Wins = 0
                        },
                        new
                        {
                            Id = 60,
                            Losses = 0,
                            Name = "KO",
                            Shitlo = 0,
                            Wins = 0
                        },
                        new
                        {
                            Id = 61,
                            Losses = 0,
                            Name = "Jacke",
                            Shitlo = 0,
                            Wins = 0
                        },
                        new
                        {
                            Id = 62,
                            Losses = 0,
                            Name = "Demon",
                            Shitlo = 0,
                            Wins = 0
                        },
                        new
                        {
                            Id = 63,
                            Losses = 0,
                            Name = "Jake",
                            Shitlo = 0,
                            Wins = 0
                        },
                        new
                        {
                            Id = 64,
                            Losses = 0,
                            Name = "Beware",
                            Shitlo = 0,
                            Wins = 0
                        },
                        new
                        {
                            Id = 65,
                            Losses = 0,
                            Name = "Gatos",
                            Shitlo = 0,
                            Wins = 0
                        },
                        new
                        {
                            Id = 66,
                            Losses = 0,
                            Name = "Azin",
                            Shitlo = 0,
                            Wins = 0
                        },
                        new
                        {
                            Id = 67,
                            Losses = 0,
                            Name = "Jorn",
                            Shitlo = 0,
                            Wins = 0
                        },
                        new
                        {
                            Id = 68,
                            Losses = 0,
                            Name = "Chrizzo",
                            Shitlo = 0,
                            Wins = 0
                        },
                        new
                        {
                            Id = 69,
                            Losses = 0,
                            Name = "Matze",
                            Shitlo = 0,
                            Wins = 0
                        },
                        new
                        {
                            Id = 70,
                            Losses = 0,
                            Name = "Saints",
                            Shitlo = 0,
                            Wins = 0
                        },
                        new
                        {
                            Id = 71,
                            Losses = 0,
                            Name = "Pfefferkuchen",
                            Shitlo = 0,
                            Wins = 0
                        },
                        new
                        {
                            Id = 72,
                            Losses = 0,
                            Name = "Smoki",
                            Shitlo = 0,
                            Wins = 0
                        },
                        new
                        {
                            Id = 73,
                            Losses = 0,
                            Name = "Dome",
                            Shitlo = 0,
                            Wins = 0
                        },
                        new
                        {
                            Id = 74,
                            Losses = 0,
                            Name = "Trunkz",
                            Shitlo = 0,
                            Wins = 0
                        });
                });

            modelBuilder.Entity("GvGRank_Server.Models.Vote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date");

                    b.Property<int>("IpId");

                    b.Property<int>("LoseId");

                    b.Property<int>("WinId");

                    b.HasKey("Id");

                    b.ToTable("Votes");
                });
#pragma warning restore 612, 618
        }
    }
}

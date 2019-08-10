using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GvGRank_Server.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IPs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ip = table.Column<string>(maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IPs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 20, nullable: false),
                    Shitlo = table.Column<int>(nullable: false),
                    Wins = table.Column<int>(nullable: false),
                    Losses = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Votes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTime>(nullable: false),
                    IpId = table.Column<int>(nullable: false),
                    WinId = table.Column<int>(nullable: false),
                    LoseId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Votes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Losses", "Name", "Shitlo", "Wins" },
                values: new object[,]
                {
                    { 1, 0, "Aspect", 0, 0 },
                    { 53, 0, "Hash", 0, 0 },
                    { 52, 0, "Hemo", 0, 0 },
                    { 51, 0, "Math", 0, 0 },
                    { 50, 0, "Mario", 0, 0 },
                    { 49, 0, "Nick", 0, 0 },
                    { 48, 0, "Rudi", 0, 0 },
                    { 54, 0, "Miru", 0, 0 },
                    { 47, 0, "Yoshi", 0, 0 },
                    { 45, 0, "Eraziel", 0, 0 },
                    { 44, 0, "Jonas", 0, 0 },
                    { 43, 0, "Pally", 0, 0 },
                    { 42, 0, "Remede", 0, 0 },
                    { 41, 0, "Izzy", 0, 0 },
                    { 40, 0, "Lua Kavanuh", 0, 0 },
                    { 46, 0, "Santana", 0, 0 },
                    { 55, 0, "Sync", 0, 0 },
                    { 56, 0, "Moo", 0, 0 },
                    { 57, 0, "Bounty", 0, 0 },
                    { 72, 0, "Smoki", 0, 0 },
                    { 71, 0, "Pfefferkuchen", 0, 0 },
                    { 70, 0, "Saints", 0, 0 },
                    { 69, 0, "Matze", 0, 0 },
                    { 68, 0, "Chrizzo", 0, 0 },
                    { 67, 0, "Jorn", 0, 0 },
                    { 66, 0, "Azin", 0, 0 },
                    { 65, 0, "Gatos", 0, 0 },
                    { 64, 0, "Beware", 0, 0 },
                    { 63, 0, "Jake", 0, 0 },
                    { 62, 0, "Demon", 0, 0 },
                    { 61, 0, "Jacke", 0, 0 },
                    { 60, 0, "KO", 0, 0 },
                    { 59, 0, "Resi", 0, 0 },
                    { 58, 0, "Tequila", 0, 0 },
                    { 39, 0, "Maga", 0, 0 },
                    { 38, 0, "Chamalee", 0, 0 },
                    { 37, 0, "Spartan", 0, 0 },
                    { 36, 0, "Messy", 0, 0 },
                    { 16, 0, "Rainy", 0, 0 },
                    { 15, 0, "Candyboy", 0, 0 },
                    { 14, 0, "Yoko", 0, 0 },
                    { 13, 0, "Dopos", 0, 0 },
                    { 12, 0, "Butters", 0, 0 },
                    { 11, 0, "Takida", 0, 0 },
                    { 10, 0, "Fluxy", 0, 0 },
                    { 9, 0, "Oln", 0, 0 },
                    { 8, 0, "Ice", 0, 0 },
                    { 7, 0, "Sam", 0, 0 },
                    { 6, 0, "Willy", 0, 0 },
                    { 5, 0, "Purif", 0, 0 },
                    { 4, 0, "Maverick", 0, 0 },
                    { 3, 0, "Vesto", 0, 0 },
                    { 2, 0, "Lynie", 0, 0 },
                    { 17, 0, "Akemi", 0, 0 },
                    { 73, 0, "Dome", 0, 0 },
                    { 18, 0, "Lisek", 0, 0 },
                    { 20, 0, "Sven", 0, 0 },
                    { 35, 0, "Lao", 0, 0 },
                    { 34, 0, "Fate", 0, 0 },
                    { 33, 0, "Sebbe", 0, 0 },
                    { 32, 0, "Honk", 0, 0 },
                    { 31, 0, "Zynkh", 0, 0 },
                    { 30, 0, "Newty", 0, 0 },
                    { 29, 0, "Chunin", 0, 0 },
                    { 28, 0, "Motoko", 0, 0 },
                    { 27, 0, "Yamamoto", 0, 0 },
                    { 26, 0, "Nihal", 0, 0 },
                    { 25, 0, "Holye", 0, 0 },
                    { 24, 0, "Kasperov", 0, 0 },
                    { 23, 0, "Ali", 0, 0 },
                    { 22, 0, "Brent", 0, 0 },
                    { 21, 0, "Teddy", 0, 0 },
                    { 19, 0, "Kay", 0, 0 },
                    { 74, 0, "Trunkz", 0, 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IPs");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "Votes");
        }
    }
}

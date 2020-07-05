using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MegaHack.Business.Migrations
{
    public partial class addBonusClient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NickName",
                table: "Client");

            migrationBuilder.AddColumn<int>(
                name: "MyBonus",
                table: "Client",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Bonus",
                columns: table => new
                {
                    BonusId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    QuantBonus = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ExpirationDateTime = table.Column<DateTime>(nullable: false),
                    CompanyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bonus", x => x.BonusId);
                    table.ForeignKey(
                        name: "FK_Bonus_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BonusClient",
                columns: table => new
                {
                    BonusClientId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PendingToActive = table.Column<bool>(nullable: false),
                    Actived = table.Column<bool>(nullable: false),
                    ActivationDate = table.Column<DateTime>(nullable: false),
                    ClientId = table.Column<int>(nullable: false),
                    BonusId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BonusClient", x => x.BonusClientId);
                    table.ForeignKey(
                        name: "FK_BonusClient_Bonus_BonusId",
                        column: x => x.BonusId,
                        principalTable: "Bonus",
                        principalColumn: "BonusId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BonusClient_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Client",
                        principalColumn: "ClientID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bonus_CompanyId",
                table: "Bonus",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_BonusClient_BonusId",
                table: "BonusClient",
                column: "BonusId");

            migrationBuilder.CreateIndex(
                name: "IX_BonusClient_ClientId",
                table: "BonusClient",
                column: "ClientId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BonusClient");

            migrationBuilder.DropTable(
                name: "Bonus");

            migrationBuilder.DropColumn(
                name: "MyBonus",
                table: "Client");

            migrationBuilder.AddColumn<string>(
                name: "NickName",
                table: "Client",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}

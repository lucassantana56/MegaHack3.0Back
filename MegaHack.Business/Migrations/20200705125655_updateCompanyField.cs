using Microsoft.EntityFrameworkCore.Migrations;

namespace MegaHack.Business.Migrations
{
    public partial class updateCompanyField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Cep",
                table: "Address",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Cep",
                table: "Address",
                type: "int",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}

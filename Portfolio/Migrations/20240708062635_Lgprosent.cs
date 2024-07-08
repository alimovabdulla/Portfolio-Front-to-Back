using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Portfolio.Migrations
{
    public partial class Lgprosent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Prosent",
                table: "lgProsents",
                newName: "Prosent3");

            migrationBuilder.RenameColumn(
                name: "Language",
                table: "lgProsents",
                newName: "Prosent2");

            migrationBuilder.AddColumn<string>(
                name: "Language1",
                table: "lgProsents",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Language2",
                table: "lgProsents",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Language3",
                table: "lgProsents",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Prosent1",
                table: "lgProsents",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Language1",
                table: "lgProsents");

            migrationBuilder.DropColumn(
                name: "Language2",
                table: "lgProsents");

            migrationBuilder.DropColumn(
                name: "Language3",
                table: "lgProsents");

            migrationBuilder.DropColumn(
                name: "Prosent1",
                table: "lgProsents");

            migrationBuilder.RenameColumn(
                name: "Prosent3",
                table: "lgProsents",
                newName: "Prosent");

            migrationBuilder.RenameColumn(
                name: "Prosent2",
                table: "lgProsents",
                newName: "Language");
        }
    }
}

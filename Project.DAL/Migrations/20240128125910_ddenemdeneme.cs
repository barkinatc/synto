using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.DAL.Migrations
{
    /// <inheritdoc />
    public partial class ddenemdeneme : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FaaliyetVeProjeler",
                table: "Dart",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ihtiyaclar",
                table: "Dart",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MaliyetTahmini",
                table: "Dart",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Riskler",
                table: "Dart",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tespitler",
                table: "Dart",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FaaliyetVeProjeler",
                table: "Dart");

            migrationBuilder.DropColumn(
                name: "Ihtiyaclar",
                table: "Dart");

            migrationBuilder.DropColumn(
                name: "MaliyetTahmini",
                table: "Dart");

            migrationBuilder.DropColumn(
                name: "Riskler",
                table: "Dart");

            migrationBuilder.DropColumn(
                name: "Tespitler",
                table: "Dart");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.DAL.Migrations
{
    /// <inheritdoc />
    public partial class edmeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Indicators",
                newName: "Yirmi24");

            migrationBuilder.AddColumn<string>(
                name: "HedefeEtkisiYuzde",
                table: "Indicators",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IS",
                table: "Indicators",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PlanDonemiBaslangicDegeri",
                table: "Indicators",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RS",
                table: "Indicators",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Yirmi20",
                table: "Indicators",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Yirmi21",
                table: "Indicators",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Yirmi22",
                table: "Indicators",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Yirmi23",
                table: "Indicators",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HedefeEtkisiYuzde",
                table: "Indicators");

            migrationBuilder.DropColumn(
                name: "IS",
                table: "Indicators");

            migrationBuilder.DropColumn(
                name: "PlanDonemiBaslangicDegeri",
                table: "Indicators");

            migrationBuilder.DropColumn(
                name: "RS",
                table: "Indicators");

            migrationBuilder.DropColumn(
                name: "Yirmi20",
                table: "Indicators");

            migrationBuilder.DropColumn(
                name: "Yirmi21",
                table: "Indicators");

            migrationBuilder.DropColumn(
                name: "Yirmi22",
                table: "Indicators");

            migrationBuilder.DropColumn(
                name: "Yirmi23",
                table: "Indicators");

            migrationBuilder.RenameColumn(
                name: "Yirmi24",
                table: "Indicators",
                newName: "Description");
        }
    }
}

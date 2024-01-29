using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.DAL.Migrations
{
    /// <inheritdoc />
    public partial class deneme31 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DartID",
                table: "Missions",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Missions_DartID",
                table: "Missions",
                column: "DartID");

            migrationBuilder.AddForeignKey(
                name: "FK_Missions_Dart_DartID",
                table: "Missions",
                column: "DartID",
                principalTable: "Dart",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Missions_Dart_DartID",
                table: "Missions");

            migrationBuilder.DropIndex(
                name: "IX_Missions_DartID",
                table: "Missions");

            migrationBuilder.DropColumn(
                name: "DartID",
                table: "Missions");
        }
    }
}

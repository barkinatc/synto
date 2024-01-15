using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.DAL.Migrations
{
    /// <inheritdoc />
    public partial class deneme2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryID",
                table: "Missions",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Missions_CategoryID",
                table: "Missions",
                column: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Missions_Categories_CategoryID",
                table: "Missions",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Missions_Categories_CategoryID",
                table: "Missions");

            migrationBuilder.DropIndex(
                name: "IX_Missions_CategoryID",
                table: "Missions");

            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "Missions");
        }
    }
}

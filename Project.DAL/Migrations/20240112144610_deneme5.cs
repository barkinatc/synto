using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.DAL.Migrations
{
    /// <inheritdoc />
    public partial class deneme5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PageID",
                table: "Missions",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Missions_PageID",
                table: "Missions",
                column: "PageID");

            migrationBuilder.AddForeignKey(
                name: "FK_Missions_Pages_PageID",
                table: "Missions",
                column: "PageID",
                principalTable: "Pages",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Missions_Pages_PageID",
                table: "Missions");

            migrationBuilder.DropIndex(
                name: "IX_Missions_PageID",
                table: "Missions");

            migrationBuilder.DropColumn(
                name: "PageID",
                table: "Missions");
        }
    }
}

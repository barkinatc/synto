using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.DAL.Migrations
{
    /// <inheritdoc />
    public partial class deneme101 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AppUserID",
                table: "Missions",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Missions_AppUserID",
                table: "Missions",
                column: "AppUserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Missions_AspNetUsers_AppUserID",
                table: "Missions",
                column: "AppUserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Missions_AspNetUsers_AppUserID",
                table: "Missions");

            migrationBuilder.DropIndex(
                name: "IX_Missions_AppUserID",
                table: "Missions");

            migrationBuilder.DropColumn(
                name: "AppUserID",
                table: "Missions");
        }
    }
}

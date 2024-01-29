using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.DAL.Migrations
{
    /// <inheritdoc />
    public partial class deneme02 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AppUserID",
                table: "Pages",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pages_AppUserID",
                table: "Pages",
                column: "AppUserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Pages_AspNetUsers_AppUserID",
                table: "Pages",
                column: "AppUserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropForeignKey(
                name: "FK_Pages_AspNetUsers_AppUserID",
                table: "Pages");

            migrationBuilder.DropIndex(
                name: "IX_Pages_AppUserID",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "AppUserID",
                table: "Pages");

        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.DAL.Migrations
{
    /// <inheritdoc />
    public partial class deneme3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "InstitutionID",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_InstitutionID",
                table: "AspNetUsers",
                column: "InstitutionID");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Institutions_InstitutionID",
                table: "AspNetUsers",
                column: "InstitutionID",
                principalTable: "Institutions",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Institutions_InstitutionID",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_InstitutionID",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "InstitutionID",
                table: "AspNetUsers");
        }
    }
}

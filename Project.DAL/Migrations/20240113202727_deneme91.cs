using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.DAL.Migrations
{
    /// <inheritdoc />
    public partial class deneme91 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "InstitutionID",
                table: "Pages",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pages_InstitutionID",
                table: "Pages",
                column: "InstitutionID");

            migrationBuilder.AddForeignKey(
                name: "FK_Pages_Institutions_InstitutionID",
                table: "Pages",
                column: "InstitutionID",
                principalTable: "Institutions",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pages_Institutions_InstitutionID",
                table: "Pages");

            migrationBuilder.DropIndex(
                name: "IX_Pages_InstitutionID",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "InstitutionID",
                table: "Pages");
        }
    }
}

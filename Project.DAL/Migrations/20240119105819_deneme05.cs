using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.DAL.Migrations
{
    /// <inheritdoc />
    public partial class deneme05 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Directorate",
                table: "Indicators");

            migrationBuilder.AddColumn<int>(
                name: "InstitutionID",
                table: "Indicators",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Indicators_InstitutionID",
                table: "Indicators",
                column: "InstitutionID");

            migrationBuilder.AddForeignKey(
                name: "FK_Indicators_Institutions_InstitutionID",
                table: "Indicators",
                column: "InstitutionID",
                principalTable: "Institutions",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Indicators_Institutions_InstitutionID",
                table: "Indicators");

            migrationBuilder.DropIndex(
                name: "IX_Indicators_InstitutionID",
                table: "Indicators");

            migrationBuilder.DropColumn(
                name: "InstitutionID",
                table: "Indicators");

            migrationBuilder.AddColumn<string>(
                name: "Directorate",
                table: "Indicators",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}

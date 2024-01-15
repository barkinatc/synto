using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.DAL.Migrations
{
    /// <inheritdoc />
    public partial class _2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProjectAID",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProjectID",
                table: "Categories",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ProjectAID",
                table: "Categories",
                column: "ProjectAID");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_ProjectAs_ProjectAID",
                table: "Categories",
                column: "ProjectAID",
                principalTable: "ProjectAs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_ProjectAs_ProjectAID",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_ProjectAID",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "ProjectAID",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "ProjectID",
                table: "Categories");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.DAL.Migrations
{
    /// <inheritdoc />
    public partial class _3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_ProjectAs_ProjectAID",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "ProjectID",
                table: "Categories");

            migrationBuilder.AlterColumn<int>(
                name: "ProjectAID",
                table: "Categories",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_ProjectAs_ProjectAID",
                table: "Categories",
                column: "ProjectAID",
                principalTable: "ProjectAs",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_ProjectAs_ProjectAID",
                table: "Categories");

            migrationBuilder.AlterColumn<int>(
                name: "ProjectAID",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProjectID",
                table: "Categories",
                type: "int",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_ProjectAs_ProjectAID",
                table: "Categories",
                column: "ProjectAID",
                principalTable: "ProjectAs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

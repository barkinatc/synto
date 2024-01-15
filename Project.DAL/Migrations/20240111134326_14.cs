using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.DAL.Migrations
{
    /// <inheritdoc />
    public partial class _14 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NumberOfPage",
                table: "Pages",
                newName: "Order");

            migrationBuilder.AddColumn<string>(
                name: "PageType",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PageType",
                table: "Pages");

            migrationBuilder.RenameColumn(
                name: "Order",
                table: "Pages",
                newName: "NumberOfPage");
        }
    }
}

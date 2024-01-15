using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.DAL.Migrations
{
    /// <inheritdoc />
    public partial class _11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Content",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "Data",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Pages");

            migrationBuilder.AddColumn<int>(
                name: "NumberOfPage",
                table: "Pages",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Contents",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PageID = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contents", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Contents_Pages_PageID",
                        column: x => x.PageID,
                        principalTable: "Pages",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Datas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PageID = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Datas", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Datas_Pages_PageID",
                        column: x => x.PageID,
                        principalTable: "Pages",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PageID = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Images_Pages_PageID",
                        column: x => x.PageID,
                        principalTable: "Pages",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contents_PageID",
                table: "Contents",
                column: "PageID");

            migrationBuilder.CreateIndex(
                name: "IX_Datas_PageID",
                table: "Datas",
                column: "PageID");

            migrationBuilder.CreateIndex(
                name: "IX_Images_PageID",
                table: "Images",
                column: "PageID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contents");

            migrationBuilder.DropTable(
                name: "Datas");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropColumn(
                name: "NumberOfPage",
                table: "Pages");

            migrationBuilder.AddColumn<string>(
                name: "Content",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Data",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}

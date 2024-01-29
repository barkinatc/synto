using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.DAL.Migrations
{
    /// <inheritdoc />
    public partial class denem56 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contents_Pages_PageID",
                table: "Contents");

            migrationBuilder.DropForeignKey(
                name: "FK_Datas_Pages_PageID",
                table: "Datas");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_Pages_PageID",
                table: "Images");

            migrationBuilder.RenameColumn(
                name: "PageID",
                table: "Images",
                newName: "CategoryID");

            migrationBuilder.RenameIndex(
                name: "IX_Images_PageID",
                table: "Images",
                newName: "IX_Images_CategoryID");

            migrationBuilder.RenameColumn(
                name: "PageID",
                table: "Datas",
                newName: "CategoryID");

            migrationBuilder.RenameIndex(
                name: "IX_Datas_PageID",
                table: "Datas",
                newName: "IX_Datas_CategoryID");

            migrationBuilder.RenameColumn(
                name: "PageID",
                table: "Contents",
                newName: "CategoryID");

            migrationBuilder.RenameIndex(
                name: "IX_Contents_PageID",
                table: "Contents",
                newName: "IX_Contents_CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Contents_Categories_CategoryID",
                table: "Contents",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Datas_Categories_CategoryID",
                table: "Datas",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Categories_CategoryID",
                table: "Images",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contents_Categories_CategoryID",
                table: "Contents");

            migrationBuilder.DropForeignKey(
                name: "FK_Datas_Categories_CategoryID",
                table: "Datas");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_Categories_CategoryID",
                table: "Images");

            migrationBuilder.RenameColumn(
                name: "CategoryID",
                table: "Images",
                newName: "PageID");

            migrationBuilder.RenameIndex(
                name: "IX_Images_CategoryID",
                table: "Images",
                newName: "IX_Images_PageID");

            migrationBuilder.RenameColumn(
                name: "CategoryID",
                table: "Datas",
                newName: "PageID");

            migrationBuilder.RenameIndex(
                name: "IX_Datas_CategoryID",
                table: "Datas",
                newName: "IX_Datas_PageID");

            migrationBuilder.RenameColumn(
                name: "CategoryID",
                table: "Contents",
                newName: "PageID");

            migrationBuilder.RenameIndex(
                name: "IX_Contents_CategoryID",
                table: "Contents",
                newName: "IX_Contents_PageID");

            migrationBuilder.AddForeignKey(
                name: "FK_Contents_Pages_PageID",
                table: "Contents",
                column: "PageID",
                principalTable: "Pages",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Datas_Pages_PageID",
                table: "Datas",
                column: "PageID",
                principalTable: "Pages",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Pages_PageID",
                table: "Images",
                column: "PageID",
                principalTable: "Pages",
                principalColumn: "ID");
        }
    }
}

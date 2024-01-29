using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.DAL.Migrations
{
    /// <inheritdoc />
    public partial class deneme03 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pages_AspNetUsers_AppUserID",
                table: "Pages");

            migrationBuilder.DropForeignKey(
                name: "FK_Pages_Institutions_InstitutionID",
                table: "Pages");

            migrationBuilder.DropIndex(
                name: "IX_Pages_AppUserID",
                table: "Pages");

            migrationBuilder.DropIndex(
                name: "IX_Pages_InstitutionID",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "AppUserID",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "InstitutionID",
                table: "Pages");

            migrationBuilder.AddColumn<int>(
                name: "DartID",
                table: "Institutions",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Dart",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amac = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hedef = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SorumluBirim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectID = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dart", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Dart_ProjectAs_ProjectID",
                        column: x => x.ProjectID,
                        principalTable: "ProjectAs",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "PageAppUsers",
                columns: table => new
                {
                    PageID = table.Column<int>(type: "int", nullable: false),
                    AppUserID = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PageAppUsers", x => new { x.PageID, x.AppUserID });
                    table.ForeignKey(
                        name: "FK_PageAppUsers_AspNetUsers_AppUserID",
                        column: x => x.AppUserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PageAppUsers_Pages_PageID",
                        column: x => x.PageID,
                        principalTable: "Pages",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PageInstitutions",
                columns: table => new
                {
                    PageID = table.Column<int>(type: "int", nullable: false),
                    InstitutionID = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PageInstitutions", x => new { x.PageID, x.InstitutionID });
                    table.ForeignKey(
                        name: "FK_PageInstitutions_Institutions_InstitutionID",
                        column: x => x.InstitutionID,
                        principalTable: "Institutions",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PageInstitutions_Pages_PageID",
                        column: x => x.PageID,
                        principalTable: "Pages",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Institutions_DartID",
                table: "Institutions",
                column: "DartID");

            migrationBuilder.CreateIndex(
                name: "IX_Dart_ProjectID",
                table: "Dart",
                column: "ProjectID");

            migrationBuilder.CreateIndex(
                name: "IX_PageAppUsers_AppUserID",
                table: "PageAppUsers",
                column: "AppUserID");

            migrationBuilder.CreateIndex(
                name: "IX_PageInstitutions_InstitutionID",
                table: "PageInstitutions",
                column: "InstitutionID");

            migrationBuilder.AddForeignKey(
                name: "FK_Institutions_Dart_DartID",
                table: "Institutions",
                column: "DartID",
                principalTable: "Dart",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Institutions_Dart_DartID",
                table: "Institutions");

            migrationBuilder.DropTable(
                name: "Dart");

            migrationBuilder.DropTable(
                name: "PageAppUsers");

            migrationBuilder.DropTable(
                name: "PageInstitutions");

            migrationBuilder.DropIndex(
                name: "IX_Institutions_DartID",
                table: "Institutions");

            migrationBuilder.DropColumn(
                name: "DartID",
                table: "Institutions");

            migrationBuilder.AddColumn<int>(
                name: "AppUserID",
                table: "Pages",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InstitutionID",
                table: "Pages",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pages_AppUserID",
                table: "Pages",
                column: "AppUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Pages_InstitutionID",
                table: "Pages",
                column: "InstitutionID");

            migrationBuilder.AddForeignKey(
                name: "FK_Pages_AspNetUsers_AppUserID",
                table: "Pages",
                column: "AppUserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pages_Institutions_InstitutionID",
                table: "Pages",
                column: "InstitutionID",
                principalTable: "Institutions",
                principalColumn: "ID");
        }
    }
}

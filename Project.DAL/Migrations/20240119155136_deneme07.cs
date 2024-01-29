using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.DAL.Migrations
{
    /// <inheritdoc />
    public partial class deneme07 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AppUserID",
                table: "Dart",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "DartIndicators",
                columns: table => new
                {
                    DartID = table.Column<int>(type: "int", nullable: false),
                    IndicatorID = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DartIndicators", x => new { x.DartID, x.IndicatorID });
                    table.ForeignKey(
                        name: "FK_DartIndicators_Dart_DartID",
                        column: x => x.DartID,
                        principalTable: "Dart",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DartIndicators_Indicators_IndicatorID",
                        column: x => x.IndicatorID,
                        principalTable: "Indicators",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dart_AppUserID",
                table: "Dart",
                column: "AppUserID");

            migrationBuilder.CreateIndex(
                name: "IX_DartIndicators_IndicatorID",
                table: "DartIndicators",
                column: "IndicatorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Dart_AspNetUsers_AppUserID",
                table: "Dart",
                column: "AppUserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dart_AspNetUsers_AppUserID",
                table: "Dart");

            migrationBuilder.DropTable(
                name: "DartIndicators");

            migrationBuilder.DropIndex(
                name: "IX_Dart_AppUserID",
                table: "Dart");

            migrationBuilder.DropColumn(
                name: "AppUserID",
                table: "Dart");
        }
    }
}

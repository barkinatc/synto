using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.DAL.Migrations
{
    /// <inheritdoc />
    public partial class deneme32 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Missions_AspNetUsers_AppUserID",
                table: "Missions");

            migrationBuilder.DropIndex(
                name: "IX_Missions_AppUserID",
                table: "Missions");

            migrationBuilder.DropColumn(
                name: "AppUserID",
                table: "Missions");

            migrationBuilder.CreateTable(
                name: "MissionAppUsers",
                columns: table => new
                {
                    MissionID = table.Column<int>(type: "int", nullable: false),
                    AppUserID = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MissionAppUsers", x => new { x.AppUserID, x.MissionID });
                    table.ForeignKey(
                        name: "FK_MissionAppUsers_AspNetUsers_AppUserID",
                        column: x => x.AppUserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MissionAppUsers_Missions_MissionID",
                        column: x => x.MissionID,
                        principalTable: "Missions",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MissionAppUsers_MissionID",
                table: "MissionAppUsers",
                column: "MissionID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MissionAppUsers");

            migrationBuilder.AddColumn<int>(
                name: "AppUserID",
                table: "Missions",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Missions_AppUserID",
                table: "Missions",
                column: "AppUserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Missions_AspNetUsers_AppUserID",
                table: "Missions",
                column: "AppUserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}

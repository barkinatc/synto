using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.DAL.Migrations
{
    /// <inheritdoc />
    public partial class _16 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PageUniqueCode",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Missions",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MissionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InstitutionID = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Missions", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Missions_Institutions_InstitutionID",
                        column: x => x.InstitutionID,
                        principalTable: "Institutions",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Missions_InstitutionID",
                table: "Missions",
                column: "InstitutionID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Missions");

            migrationBuilder.DropColumn(
                name: "PageUniqueCode",
                table: "Pages");
        }
    }
}

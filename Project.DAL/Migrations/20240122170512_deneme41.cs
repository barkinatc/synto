using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.DAL.Migrations
{
    /// <inheritdoc />
    public partial class deneme41 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Missions_Institutions_InstitutionID",
                table: "Missions");

            migrationBuilder.DropIndex(
                name: "IX_Missions_InstitutionID",
                table: "Missions");

            migrationBuilder.DropColumn(
                name: "InstitutionID",
                table: "Missions");

            migrationBuilder.CreateTable(
                name: "MissionInstitutions",
                columns: table => new
                {
                    MissionID = table.Column<int>(type: "int", nullable: false),
                    InstitutionID = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MissionInstitutions", x => new { x.MissionID, x.InstitutionID });
                    table.ForeignKey(
                        name: "FK_MissionInstitutions_Institutions_InstitutionID",
                        column: x => x.InstitutionID,
                        principalTable: "Institutions",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MissionInstitutions_Missions_MissionID",
                        column: x => x.MissionID,
                        principalTable: "Missions",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MissionInstitutions_InstitutionID",
                table: "MissionInstitutions",
                column: "InstitutionID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MissionInstitutions");

            migrationBuilder.AddColumn<int>(
                name: "InstitutionID",
                table: "Missions",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Missions_InstitutionID",
                table: "Missions",
                column: "InstitutionID");

            migrationBuilder.AddForeignKey(
                name: "FK_Missions_Institutions_InstitutionID",
                table: "Missions",
                column: "InstitutionID",
                principalTable: "Institutions",
                principalColumn: "ID");
        }
    }
}

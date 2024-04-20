using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PortalSystemWebApp.Migrations
{
    /// <inheritdoc />
    public partial class programtablecrudpages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProgramClass",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Detail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GradeLevel = table.Column<int>(type: "int", nullable: false),
                    MaxClassSize = table.Column<int>(type: "int", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgramClass", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationUserProgramClass",
                columns: table => new
                {
                    EnrolledUsersId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProgramClassId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserProgramClass", x => new { x.EnrolledUsersId, x.ProgramClassId });
                    table.ForeignKey(
                        name: "FK_ApplicationUserProgramClass_AspNetUsers_EnrolledUsersId",
                        column: x => x.EnrolledUsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApplicationUserProgramClass_ProgramClass_ProgramClassId",
                        column: x => x.ProgramClassId,
                        principalTable: "ProgramClass",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserProgramClass_ProgramClassId",
                table: "ApplicationUserProgramClass",
                column: "ProgramClassId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationUserProgramClass");

            migrationBuilder.DropTable(
                name: "ProgramClass");
        }
    }
}

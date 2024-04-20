using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PortalSystemWebApp.Migrations
{
    /// <inheritdoc />
    public partial class enrolledprograminappuser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserProgramClass_ProgramClass_ProgramClassId",
                table: "ApplicationUserProgramClass");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApplicationUserProgramClass",
                table: "ApplicationUserProgramClass");

            migrationBuilder.DropIndex(
                name: "IX_ApplicationUserProgramClass_ProgramClassId",
                table: "ApplicationUserProgramClass");

            migrationBuilder.RenameColumn(
                name: "ProgramClassId",
                table: "ApplicationUserProgramClass",
                newName: "EnrolledProgramsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApplicationUserProgramClass",
                table: "ApplicationUserProgramClass",
                columns: new[] { "EnrolledProgramsId", "EnrolledUsersId" });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserProgramClass_EnrolledUsersId",
                table: "ApplicationUserProgramClass",
                column: "EnrolledUsersId");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUserProgramClass_ProgramClass_EnrolledProgramsId",
                table: "ApplicationUserProgramClass",
                column: "EnrolledProgramsId",
                principalTable: "ProgramClass",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserProgramClass_ProgramClass_EnrolledProgramsId",
                table: "ApplicationUserProgramClass");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApplicationUserProgramClass",
                table: "ApplicationUserProgramClass");

            migrationBuilder.DropIndex(
                name: "IX_ApplicationUserProgramClass_EnrolledUsersId",
                table: "ApplicationUserProgramClass");

            migrationBuilder.RenameColumn(
                name: "EnrolledProgramsId",
                table: "ApplicationUserProgramClass",
                newName: "ProgramClassId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApplicationUserProgramClass",
                table: "ApplicationUserProgramClass",
                columns: new[] { "EnrolledUsersId", "ProgramClassId" });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserProgramClass_ProgramClassId",
                table: "ApplicationUserProgramClass",
                column: "ProgramClassId");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUserProgramClass_ProgramClass_ProgramClassId",
                table: "ApplicationUserProgramClass",
                column: "ProgramClassId",
                principalTable: "ProgramClass",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

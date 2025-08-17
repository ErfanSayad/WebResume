using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Resume.Presentation.Migrations
{
    /// <inheritdoc />
    public partial class initcontactUs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_experiences",
                table: "experiences");

            migrationBuilder.DropPrimaryKey(
                name: "PK_educations",
                table: "educations");

            migrationBuilder.RenameTable(
                name: "experiences",
                newName: "Experiences");

            migrationBuilder.RenameTable(
                name: "educations",
                newName: "Educations");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Experiences",
                table: "Experiences",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Educations",
                table: "Educations",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "ContactUs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsSeenByAdmin = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactUs", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContactUs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Experiences",
                table: "Experiences");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Educations",
                table: "Educations");

            migrationBuilder.RenameTable(
                name: "Experiences",
                newName: "experiences");

            migrationBuilder.RenameTable(
                name: "Educations",
                newName: "educations");

            migrationBuilder.AddPrimaryKey(
                name: "PK_experiences",
                table: "experiences",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_educations",
                table: "educations",
                column: "Id");
        }
    }
}

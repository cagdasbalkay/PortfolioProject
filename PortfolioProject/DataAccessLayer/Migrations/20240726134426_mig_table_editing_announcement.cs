using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_table_editing_announcement : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Test1",
                table: "Test1");

            migrationBuilder.RenameTable(
                name: "Test1",
                newName: "Test1s");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Test1s",
                table: "Test1s",
                column: "ID");

            migrationBuilder.CreateTable(
                name: "Announcements",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Announcements", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Announcements");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Test1s",
                table: "Test1s");

            migrationBuilder.RenameTable(
                name: "Test1s",
                newName: "Test1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Test1",
                table: "Test1",
                column: "ID");
        }
    }
}

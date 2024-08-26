using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_announcement_add : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}

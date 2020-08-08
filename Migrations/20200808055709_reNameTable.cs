using Microsoft.EntityFrameworkCore.Migrations;

namespace efc3.Migrations
{
    public partial class reNameTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Match",
                table: "Match");

            migrationBuilder.RenameTable(
                name: "Match",
                newName: "Haha");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Haha",
                table: "Haha",
                column: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Haha",
                table: "Haha");

            migrationBuilder.RenameTable(
                name: "Haha",
                newName: "Match");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Match",
                table: "Match",
                column: "id");
        }
    }
}

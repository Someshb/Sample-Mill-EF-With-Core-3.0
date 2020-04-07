using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class GetStudentByID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentEntities",
                table: "StudentEntities");

            migrationBuilder.RenameTable(
                name: "StudentEntities",
                newName: "StudentEntity");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentEntity",
                table: "StudentEntity",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentEntity",
                table: "StudentEntity");

            migrationBuilder.RenameTable(
                name: "StudentEntity",
                newName: "StudentEntities");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentEntities",
                table: "StudentEntities",
                column: "Id");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class UpdateStudenEntityFOREFUpgradev2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "varchar(60)",
                table: "StudentEntities",
                newName: "Class");

            migrationBuilder.RenameColumn(
                name: "int",
                table: "StudentEntities",
                newName: "Age");

            migrationBuilder.AlterColumn<string>(
                name: "Class",
                table: "StudentEntities",
                type: "varchar(60)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Age",
                table: "StudentEntities",
                type: "varchar(5)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "StudentEntities",
                type: "varchar(60)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "StudentEntities");

            migrationBuilder.RenameColumn(
                name: "Class",
                table: "StudentEntities",
                newName: "varchar(60)");

            migrationBuilder.RenameColumn(
                name: "Age",
                table: "StudentEntities",
                newName: "int");

            migrationBuilder.AlterColumn<string>(
                name: "varchar(60)",
                table: "StudentEntities",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(60)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "int",
                table: "StudentEntities",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(5)",
                oldNullable: true);
        }
    }
}

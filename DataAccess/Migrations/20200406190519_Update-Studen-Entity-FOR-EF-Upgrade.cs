using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class UpdateStudenEntityFOREFUpgrade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StudentEntities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    varchar60 = table.Column<string>(name: "varchar(60)", nullable: true),
                    @int = table.Column<string>(name: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentEntities", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentEntities");
        }
    }
}

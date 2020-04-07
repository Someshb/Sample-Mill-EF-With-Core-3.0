using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class GetStudentByID_v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string procedure = @"CREATE PROCEDURE[dbo].[GetStudentByID]
                               -- Add the parameters for the stored procedure here

                                @ID  INT = 0
                                 AS
                                 BEGIN

                               Select * From[dbo].[Student] Where Id = @ID
                               SET NOCOUNT ON;
                               
                                END";
            migrationBuilder.Sql(procedure);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            string procedure = @"DROP PROCEDURE[dbo].[GetStudentByID]";
            migrationBuilder.Sql(procedure);
        }
    }
}

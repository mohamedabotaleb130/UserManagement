using Microsoft.EntityFrameworkCore.Migrations;

namespace UserManagementWithIdentity.Data.Migrations
{
    public partial class AssignAdminUserToAllRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO [security].[UserRoles] (UserId, RoleId) SELECT '633a3a35-c123-4a03-ae83-fe7ed326b55f', Id FROM [security].[Roles]");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM [security].[UserRoles] WHERE UserId = '633a3a35-c123-4a03-ae83-fe7ed326b55f'");

        }
    }
}

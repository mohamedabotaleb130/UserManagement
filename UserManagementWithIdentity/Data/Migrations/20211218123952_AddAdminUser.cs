using Microsoft.EntityFrameworkCore.Migrations;

namespace UserManagementWithIdentity.Data.Migrations
{
    public partial class AddAdminUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO [security].[Users] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [FirstName], [LastName], [ProfilePicture]) VALUES (N'633a3a35-c123-4a03-ae83-fe7ed326b55f', N'abotalebabotaleb2020', N'ABOTALEBABOTALEB2020', N'abotalebabotaleb2020@gmail.com', N'ABOTALEBABOTALEB2020@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEBR6pCNWmqEaRO1s1GFJbofQAAY8VK2j8377VVkUNJOon0ZIUpvc6vfiPS4iswk8mg==', N'W63GPI7PJHHTEIISZ66KCUX3DCL5E5FT', N'b26f25cc-75e7-4791-9ce2-dc4d71d225fa', NULL, 0, 0, NULL, 1, 0, N'abotaleb', N'abotaleb', NULL)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM [security].[Users] WHERE Id='633a3a35-c123-4a03-ae83-fe7ed326b55f'");
        }
    }
}

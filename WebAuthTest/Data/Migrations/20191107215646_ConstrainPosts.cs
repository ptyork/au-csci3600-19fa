using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAuthTest.Data.Migrations
{
    public partial class ConstrainPosts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Topic",
                table: "Posts",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Text",
                table: "Posts",
                maxLength: 1000,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Topic",
                table: "Posts",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Text",
                table: "Posts",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 1000);
        }
    }
}

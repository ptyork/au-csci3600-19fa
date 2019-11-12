using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAuthTest.Data.Migrations
{
    public partial class AddCourseConstraints : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Prefix",
                table: "Courses",
                maxLength: 4,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Number",
                table: "Courses",
                maxLength: 4,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Courses",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Prefix",
                table: "Courses",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 4);

            migrationBuilder.AlterColumn<string>(
                name: "Number",
                table: "Courses",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 4);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Courses",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 150);
        }
    }
}

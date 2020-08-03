using Microsoft.EntityFrameworkCore.Migrations;

namespace HelloWorldMVCwebApp.Migrations
{
    public partial class editstofile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "Publisher",
                table: "Movies");

            migrationBuilder.AddColumn<string>(
                name: "Director",
                table: "Movies",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Movies",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Language",
                table: "Movies",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReleaseDate",
                table: "Movies",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Director",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "Language",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "ReleaseDate",
                table: "Movies");

            migrationBuilder.AddColumn<string>(
                name: "Date",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Publisher",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}

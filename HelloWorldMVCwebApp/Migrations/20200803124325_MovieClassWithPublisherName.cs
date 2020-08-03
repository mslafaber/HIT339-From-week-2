using Microsoft.EntityFrameworkCore.Migrations;

namespace HelloWorldMVCwebApp.Migrations
{
    public partial class MovieClassWithPublisherName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Publisher",
                table: "Movies",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Publisher",
                table: "Movies");
        }
    }
}

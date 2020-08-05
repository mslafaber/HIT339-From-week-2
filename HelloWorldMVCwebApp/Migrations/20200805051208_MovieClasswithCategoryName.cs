using Microsoft.EntityFrameworkCore.Migrations;

namespace HelloWorldMVCwebApp.Migrations
{
    public partial class MovieClasswithCategoryName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryNameCategoryId",
                table: "Movies",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Movies_CategoryNameCategoryId",
                table: "Movies",
                column: "CategoryNameCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Categories_CategoryNameCategoryId",
                table: "Movies",
                column: "CategoryNameCategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Categories_CategoryNameCategoryId",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Movies_CategoryNameCategoryId",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "CategoryNameCategoryId",
                table: "Movies");
        }
    }
}

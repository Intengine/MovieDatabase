using Microsoft.EntityFrameworkCore.Migrations;

namespace IntengineMovie.Migrations
{
    public partial class rating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "rating",
                table: "Movie",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "rating",
                table: "Movie");
        }
    }
}
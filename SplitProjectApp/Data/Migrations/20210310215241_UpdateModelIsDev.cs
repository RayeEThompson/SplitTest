using Microsoft.EntityFrameworkCore.Migrations;

namespace SplitProjectApp.Data.Migrations
{
    public partial class UpdateModelIsDev : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDev",
                table: "Joke",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDev",
                table: "Joke");
        }
    }
}

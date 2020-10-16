using Microsoft.EntityFrameworkCore.Migrations;

namespace Product.Microservices.Migrations
{
    public partial class RemovedoldpropertyfromProductmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Old",
                table: "Products");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Old",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}

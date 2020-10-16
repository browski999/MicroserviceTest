using Microsoft.EntityFrameworkCore.Migrations;

namespace Product.Microservices.Migrations
{
    public partial class AddedSKUfortheProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SKU",
                table: "Products",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SKU",
                table: "Products");
        }
    }
}

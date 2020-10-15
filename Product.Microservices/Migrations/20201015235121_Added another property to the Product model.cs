using Microsoft.EntityFrameworkCore.Migrations;

namespace Product.Microservices.Migrations
{
    public partial class AddedanotherpropertytotheProductmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Old",
                table: "Products",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Old",
                table: "Products");
        }
    }
}

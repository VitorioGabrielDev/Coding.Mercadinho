using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mercadinho.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddNameInProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "name",
                table: "Products",
                type: "VARCHAR",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "name",
                table: "Products");
        }
    }
}

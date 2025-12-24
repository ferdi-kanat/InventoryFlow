using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InventoryFlow.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class LinkSaleToCustomer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Sales",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Sales");
        }
    }
}
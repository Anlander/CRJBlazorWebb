using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CRJBlazorWeb.Migrations
{
    /// <inheritdoc />
    public partial class SeedInit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AvailableAmount", "Description", "Image", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 100, "This is product 1", "https://i.imgur.com/QkIa5tT.jpeg", "Product 1", 100.0 },
                    { 2, 100, "This is product 2", "https://i.imgur.com/QkIa5tT.jpeg", "Product 2", 100.0 },
                    { 3, 100, "This is product 3", "https://i.imgur.com/QkIa5tT.jpeg", "Product 3", 100.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}

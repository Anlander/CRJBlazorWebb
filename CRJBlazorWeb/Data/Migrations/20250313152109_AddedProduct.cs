using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRJBlazorWeb.Migrations
{
    /// <inheritdoc />
    public partial class AddedProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AvailableAmount", "Description", "Image", "Name", "Price" },
                values: new object[] { 4, 100, "This is christers product!", "https://i.imgur.com/QkIa5tT.jpeg", "Uniq product 1337", 100.0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}

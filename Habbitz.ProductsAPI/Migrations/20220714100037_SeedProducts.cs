using Microsoft.EntityFrameworkCore.Migrations;

namespace Habbitz.ProductsAPI.Migrations
{
    public partial class SeedProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryName", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Appetizer", "A product made of flour and meat or potatoes", "https://drive.google.com/file/d/1lBr9BJIXaoc-aICwwhFjI4hu3gO4R_W4/view?usp=sharing", "Samosa", 5.0 },
                    { 2, "Appetizer", "To be added later", "https://drive.google.com/file/d/1PjE7OJWfOBQkAj-iwnF9hMD2sukfe8YV/view?usp=sharing", "Panner Tikka", 13.449999999999999 },
                    { 3, "Dessert", "To be added later", "https://drive.google.com/file/d/1H_jRrTvSAV-OXNe4NCMbYSlU87lMzAjd/view?usp=sharing", "Sweet Pie", 10.99 },
                    { 4, "Dessert", "To be added laterr", "https://drive.google.com/file/d/12UVuU89klgzU62yTyaE4NdKrflGM7uOn/view?usp=sharing", "Ice Cream", 2.6699999999999999 },
                    { 5, "Dessert", "A fancy dessert", "https://drive.google.com/file/d/12Z9dQ70racP7RMuVfZ51VP1mrCZlLsj9/view?usp=sharing", "Gelato", 8.1600000000000001 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);
        }
    }
}

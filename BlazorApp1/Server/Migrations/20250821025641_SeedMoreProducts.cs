using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp1.Server.Migrations
{
    public partial class SeedMoreProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Url",
                value: "movies");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "Url" },
                values: new object[] { "Video Games", "video-games" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Url" },
                values: new object[,]
                {
                    { 4, "Electronics", "electronics" },
                    { 5, "Travel", "travel" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Name", "Price", "Title" },
                values: new object[] { 2, "Quantum Matrix Technology Pro, HDR10+, Dolby Atmos, ultra-slim design.", "https://image.samsung.com/is/image/samsung/p6pim/levant/qn75qn900cfmxzn/gallery/levant-qled-qn900c-477953-477953-477953-477953.png", "Smart TV", 4999.99m, "Samsung Neo QLED 8K Smart TV 75”" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Name", "Price", "Title" },
                values: new object[] { 5, 1, "Illustrated hardcover edition: The Fellowship, Two Towers, Return of the King.", "https://m.media-amazon.com/images/I/81t2CVWEsUL._AC_UF1000,1000_QL80_.jpg", "Fantasy Novel Collection", 89.99m, "The Lord of the Rings Trilogy Book Set" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Name", "Price", "Title" },
                values: new object[] { 4, "Advanced A17 Pro chip, titanium design, 6.7-inch display, triple-camera system.", "https://store.storeimages.cdn-apple.com/4982/as-images.apple.com/is/iphone-15-pro-max-blue-titanium", "Flagship Smartphone", 1499.99m, "Apple iPhone 15 Pro Max" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Name", "Price", "Title" },
                values: new object[] { 4, "Industry-leading noise cancelling, 30h battery, crystal-clear sound.", "https://m.media-amazon.com/images/I/61+FXSxKsBL._AC_SX679_.jpg", "Noise Cancelling Headphones", 399.00m, "Sony WH-1000XM5" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Name", "Price", "Title" },
                values: new object[,]
                {
                    { 4, 4, "12th Gen Intel Core i7, RTX 3050 Ti, 15.6-inch 4K OLED, premium build.", "https://i.dell.com/sites/csimages/App-Merchandizing_Images/all/xps-15-9520-laptop-pdp-gallery-504x350.jpg", "Professional Laptop", 2199.00m, "Dell XPS 15 Laptop" },
                    { 6, 5, "Maps, trekking routes, cultural insights, survival tips for Himalayas.", "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b3/Everest_North_Face_toward_Base_Camp_Tibet_Luca_Galuzzi_2006_%28square%29.jpg/330px-Everest_North_Face_toward_Base_Camp_Tibet_Luca_Galuzzi_2006_%28square%29.jpg", "Travel Guide", 54.50m, "Everest Base Camp Trekking Guidebook" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Url",
                value: "Movies");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "Url" },
                values: new object[] { "Video Game", "Video-Game" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Name", "Price", "Title" },
                values: new object[] { 1, "", "https://upload.wikimedia.org/wikipedia/commons/thumb/9/97/The_Earth_seen_from_Apollo_17.jpg/330px-The_Earth_seen_from_Apollo_17.jpg", "also fixed cy and hy // Editing SVG source code using c:User:Rillke/SVGedit.js", 20000m, "User:Gigibram" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Name", "Price", "Title" },
                values: new object[] { 2, "", "https://upload.wikimedia.org/wikipedia/commons/thumb/d/da/Ruler_image.jpg/330px-Ruler_image.jpg", "File uploaded using svgtranslate tool. Added translation for cnr-latn.", 6666m, "User:Jdlrobson/MainPage" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Name", "Price", "Title" },
                values: new object[] { 3, "", "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b3/Everest_North_Face_toward_Base_Camp_Tibet_Luca_Galuzzi_2006_%28square%29.jpg/330px-Everest_North_Face_toward_Base_Camp_Tibet_Luca_Galuzzi_2006_%28square%29.jpg", "File uploaded using svgtranslate tool. Added translation for az-latn.", 5325.6m, "User:Jdlrobson/MainPage/Content/en" });
        }
    }
}

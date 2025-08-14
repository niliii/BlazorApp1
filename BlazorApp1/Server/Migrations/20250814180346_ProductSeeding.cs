using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp1.Server.Migrations
{
    public partial class ProductSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "Price", "Title" },
                values: new object[] { 1, "", "https://upload.wikimedia.org/wikipedia/commons/thumb/9/97/The_Earth_seen_from_Apollo_17.jpg/330px-The_Earth_seen_from_Apollo_17.jpg", "also fixed cy and hy // Editing SVG source code using c:User:Rillke/SVGedit.js", 20000m, "User:Gigibram" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "Price", "Title" },
                values: new object[] { 2, "", "https://upload.wikimedia.org/wikipedia/commons/thumb/d/da/Ruler_image.jpg/330px-Ruler_image.jpg", "File uploaded using svgtranslate tool. Added translation for cnr-latn.", 6666m, "User:Jdlrobson/MainPage" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "Price", "Title" },
                values: new object[] { 3, "", "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b3/Everest_North_Face_toward_Base_Camp_Tibet_Luca_Galuzzi_2006_%28square%29.jpg/330px-Everest_North_Face_toward_Base_Camp_Tibet_Luca_Galuzzi_2006_%28square%29.jpg", "File uploaded using svgtranslate tool. Added translation for az-latn.", 5325.6m, "User:Jdlrobson/MainPage/Content/en" });
        }

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

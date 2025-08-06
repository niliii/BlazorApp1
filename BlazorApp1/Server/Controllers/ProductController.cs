using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyBlazorApp2.Shared;

namespace BlazorApp1.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private static List<Product> Products = new List<Product>
    {
        new Product
        {
            Id = 1,
            Title = "User:Gigibram",
            Name = "also fixed cy and hy // Editing SVG source code using c:User:Rillke/SVGedit.js",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/97/The_Earth_seen_from_Apollo_17.jpg/330px-The_Earth_seen_from_Apollo_17.jpg",
            Price = 20000
        },
        new Product
        {
            Id = 2,
            Title = "User:Jdlrobson/MainPage",
            Name = "File uploaded using svgtranslate tool. Added translation for cnr-latn.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/da/Ruler_image.jpg/330px-Ruler_image.jpg",
            Price = 6666
        },
        new Product
        {
            Id = 3,
            Title = "User:Jdlrobson/MainPage/Content/en",
            Name = "File uploaded using svgtranslate tool. Added translation for az-latn.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b3/Everest_North_Face_toward_Base_Camp_Tibet_Luca_Galuzzi_2006_%28square%29.jpg/330px-Everest_North_Face_toward_Base_Camp_Tibet_Luca_Galuzzi_2006_%28square%29.jpg",
            Price = 5325.6M
        }
    };
        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            return Ok(Products);
        }
    }
}

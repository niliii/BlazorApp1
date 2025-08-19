namespace BlazorApp1.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // --- Seed Categories ---
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Books", Url = "books" },
                new Category { Id = 2, Name = "Movies", Url = "movies" },
                new Category { Id = 3, Name = "Video Games", Url = "video-games" },
                new Category { Id = 4, Name = "Electronics", Url = "electronics" },
                new Category { Id = 5, Name = "Travel", Url = "travel" }
            );

            // --- Seed Products ---
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Apple iPhone 15 Pro Max",
                    Name = "Flagship Smartphone",
                    Description = "Advanced A17 Pro chip, titanium design, 6.7-inch display, triple-camera system.",
                    ImageUrl = "https://store.storeimages.cdn-apple.com/4982/as-images.apple.com/is/iphone-15-pro-max-blue-titanium",
                    Price = 1499.99M,
                    CategoryId = 4
                },
                new Product
                {
                    Id = 2,
                    Title = "Sony WH-1000XM5",
                    Name = "Noise Cancelling Headphones",
                    Description = "Industry-leading noise cancelling, 30h battery, crystal-clear sound.",
                    ImageUrl = "https://m.media-amazon.com/images/I/61+FXSxKsBL._AC_SX679_.jpg",
                    Price = 399.00M,
                    CategoryId = 4
                },
                new Product
                {
                    Id = 3,
                    Title = "Samsung Neo QLED 8K Smart TV 75”",
                    Name = "Smart TV",
                    Description = "Quantum Matrix Technology Pro, HDR10+, Dolby Atmos, ultra-slim design.",
                    ImageUrl = "https://image.samsung.com/is/image/samsung/p6pim/levant/qn75qn900cfmxzn/gallery/levant-qled-qn900c-477953-477953-477953-477953.png",
                    Price = 4999.99M,
                    CategoryId = 2
                },
                new Product
                {
                    Id = 4,
                    Title = "Dell XPS 15 Laptop",
                    Name = "Professional Laptop",
                    Description = "12th Gen Intel Core i7, RTX 3050 Ti, 15.6-inch 4K OLED, premium build.",
                    ImageUrl = "https://i.dell.com/sites/csimages/App-Merchandizing_Images/all/xps-15-9520-laptop-pdp-gallery-504x350.jpg",
                    Price = 2199.00M,
                    CategoryId = 4
                },
                new Product
                {
                    Id = 5,
                    Title = "The Lord of the Rings Trilogy Book Set",
                    Name = "Fantasy Novel Collection",
                    Description = "Illustrated hardcover edition: The Fellowship, Two Towers, Return of the King.",
                    ImageUrl = "https://m.media-amazon.com/images/I/81t2CVWEsUL._AC_UF1000,1000_QL80_.jpg",
                    Price = 89.99M,
                    CategoryId = 1
                },
                new Product
                {
                    Id = 6,
                    Title = "Everest Base Camp Trekking Guidebook",
                    Name = "Travel Guide",
                    Description = "Maps, trekking routes, cultural insights, survival tips for Himalayas.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b3/Everest_North_Face_toward_Base_Camp_Tibet_Luca_Galuzzi_2006_%28square%29.jpg/330px-Everest_North_Face_toward_Base_Camp_Tibet_Luca_Galuzzi_2006_%28square%29.jpg",
                    Price = 54.50M,
                    CategoryId = 5
                }
            );
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}

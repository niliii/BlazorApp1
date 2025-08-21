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
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/c/cf/Academic_disciplines_%28collage%29.jpg",
                    Price = 1499.99M,
                    CategoryId = 4
                },
                new Product
                {
                    Id = 2,
                    Title = "Sony WH-1000XM5",
                    Name = "Noise Cancelling Headphones",
                    Description = "Industry-leading noise cancelling, 30h battery, crystal-clear sound.",
                    ImageUrl = "https://fa.wikipedia.org/wiki/%D9%85%D9%86%D8%A7%D8%A8%D8%B9_%D8%B7%D8%A8%DB%8C%D8%B9%DB%8C#/media/%D9%BE%D8%B1%D9%88%D9%86%D8%AF%D9%87:Rainforest_Fatu_Hiva.jpg",
                    Price = 399.00M,
                    CategoryId = 4
                },
                new Product
                {
                    Id = 3,
                    Title = "Samsung Neo QLED 8K Smart TV 75”",
                    Name = "Smart TV",
                    Description = "Quantum Matrix Technology Pro, HDR10+, Dolby Atmos, ultra-slim design.",
                    ImageUrl = "https://fa.wikipedia.org/wiki/%D9%85%D9%86%D8%A7%D8%A8%D8%B9_%D8%B7%D8%A8%DB%8C%D8%B9%DB%8C#/media/%D9%BE%D8%B1%D9%88%D9%86%D8%AF%D9%87:Ocean_waves.jpg",
                    Price = 4999.99M,
                    CategoryId = 2
                },
                new Product
                {
                    Id = 4,
                    Title = "Dell XPS 15 Laptop",
                    Name = "Professional Laptop",
                    Description = "12th Gen Intel Core i7, RTX 3050 Ti, 15.6-inch 4K OLED, premium build.",
                    ImageUrl = "https://fa.wikipedia.org/wiki/%D9%85%D9%86%D8%A7%D8%A8%D8%B9_%D8%B7%D8%A8%DB%8C%D8%B9%DB%8C#/media/%D9%BE%D8%B1%D9%88%D9%86%D8%AF%D9%87:Udachnaya_pipe.JPG",
                    Price = 2199.00M,
                    CategoryId = 4
                },
                new Product
                {
                    Id = 5,
                    Title = "The Lord of the Rings Trilogy Book Set",
                    Name = "Fantasy Novel Collection",
                    Description = "Illustrated hardcover edition: The Fellowship, Two Towers, Return of the King.",
                    ImageUrl = "https://fa.wikipedia.org/wiki/%D9%85%D9%86%D8%A7%D8%A8%D8%B9_%D8%B7%D8%A8%DB%8C%D8%B9%DB%8C#/media/%D9%BE%D8%B1%D9%88%D9%86%D8%AF%D9%87:Windmills_D1-D4_(Thornton_Bank).jpg",
                    Price = 89.99M,
                    CategoryId = 1
                },
                new Product
                {
                    Id = 6,
                    Title = "Everest Base Camp Trekking Guidebook",
                    Name = "Travel Guide",
                    Description = "Maps, trekking routes, cultural insights, survival tips for Himalayas.",
                    ImageUrl = "https://en.wikipedia.org/wiki/Everest_base_camps?utm_source=chatgpt.com#/media/File:Khumbutse.jpg/2",
                    Price = 54.50M,
                    CategoryId = 5
                }
            );
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}

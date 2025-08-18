
namespace BlazorApp1.Server.Data
{
    public class DataContext : DbContext

    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)

        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<Category>().HasData(
               new Category
               {
                   Id = 1,
                   Name = "Books",
                   Url = "books"
               },
               new Category
               {
                   Id = 2,
                   Name = "Movies",
                   Url = "Movies"
               },
               new Category
               {
                   Id = 3,
                   Name = "Video Game",
                   Url = "Video-Game"
               }

               );



            modelBuilder.Entity<Product>().HasData(
                  new Product
                  {
                      Id = 1,
                      Title = "User:Gigibram",
                      Name = "also fixed cy and hy // Editing SVG source code using c:User:Rillke/SVGedit.js",
                      ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/97/The_Earth_seen_from_Apollo_17.jpg/330px-The_Earth_seen_from_Apollo_17.jpg",
                      Price = 20000,
                      CategoryId=1
                  },
        new Product
        {
            Id = 2,
            Title = "User:Jdlrobson/MainPage",
            Name = "File uploaded using svgtranslate tool. Added translation for cnr-latn.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/da/Ruler_image.jpg/330px-Ruler_image.jpg",
            Price = 6666,
            CategoryId=2
       
        },
        new Product
        {
            Id = 3,
            Title = "User:Jdlrobson/MainPage/Content/en",
            Name = "File uploaded using svgtranslate tool. Added translation for az-latn.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b3/Everest_North_Face_toward_Base_Camp_Tibet_Luca_Galuzzi_2006_%28square%29.jpg/330px-Everest_North_Face_toward_Base_Camp_Tibet_Luca_Galuzzi_2006_%28square%29.jpg",
            Price = 5325.6M,
            CategoryId=3
        }
                );

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }

}

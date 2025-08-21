namespace BlazorApp1.Client.Services.CategoryService
{
    public interface ICategoryService
    {
    List<Category> GetCategories { get; set; }
        Task GetCategories();

    }
}

namespace BlazorApp1.Client.Services.ProductSevice
{
    public interface IProductService
    {

        List<Product> Products { get; set; }
        Task GetProducts();
        Task<ServiceResponse<Product>>GetProduct(int productId );
    }
}


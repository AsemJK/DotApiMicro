using ProductsWebApi.Data.Models;

namespace ProductsWebApi.Services.Implementations
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAll();
        Task<Product> Add(Product product);
        Task<Product> Update(Product product);
        Task Delete(int id);
    }
}

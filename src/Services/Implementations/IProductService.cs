using DotApiMicro.Data.Models;

namespace DotApiMicro.Services.Implementations
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAll();
        Task<Product> Add(Product product);
        Task<Product> Update(Product product);
        Task Delete(Product product);
    }
}

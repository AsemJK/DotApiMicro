using DotApiMicro.Data;
using DotApiMicro.Data.Models;
using DotApiMicro.Services.Implementations;

namespace DotApiMicro.Services
{
    public class ProductService : IProductService
    {
        public ProductService(IRepository<Product> repositoryProducts)
        {
            _repositoryProducts = repositoryProducts;
        }

        public IRepository<Product> _repositoryProducts { get; }


        public async Task<IEnumerable<Product>> GetAll()
        {
            return _repositoryProducts.GetAll();
        }

        public async Task<Product> Add(Product product)
        {
            return _repositoryProducts.Add(product);
        }

        public async Task<Product> Update(Product product)
        {
            return _repositoryProducts.Update(product);
        }

        public Task Delete(Product product)
        {
            _repositoryProducts.Delete(product);
            return Task.CompletedTask;
        }
    }
}

using ProductsWebApi.Data;
using ProductsWebApi.Data.Models;
using ProductsWebApi.Services.Implementations;

namespace ProductsWebApi.Services
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

        public Task Delete(int id)
        {
            var product = _repositoryProducts.Get(id);
            if (product != null)
            {
                _repositoryProducts.Delete(product.Id);
                return Task.CompletedTask;
            }
            else
            {
                throw new Exception("Product not found");
            }
        }
    }
}

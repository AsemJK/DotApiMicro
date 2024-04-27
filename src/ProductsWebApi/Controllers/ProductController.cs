using Microsoft.AspNetCore.Mvc;
using ProductsWebApi.Data.Models;
using ProductsWebApi.Services.Implementations;

namespace ProductsWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IProductService _productService { get; }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(_productService.GetAll());
        }
        [HttpPost]
        public async Task<IActionResult> Post(Product product)
        {
            return Ok(_productService.Add(product));
        }
        [HttpPut]
        public async Task<IActionResult> Put(Product product)
        {
            return Ok(_productService.Update(product));
        }
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(_productService.Delete(id));
        }
    }
}

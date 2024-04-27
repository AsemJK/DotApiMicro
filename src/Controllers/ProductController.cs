using DotApiMicro.Data.Models;
using DotApiMicro.Services.Implementations;
using Microsoft.AspNetCore.Mvc;

namespace DotApiMicro.Controllers
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
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shopping.API.Models;
using Shopping.Client.Data;

namespace Shopping.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }
        //[HttpGet]
        //public IEnumerable<Product> Get()
        //{
        //    var rng = new Random();
        //    return Enumerable.Range(1, 5).Select(x => new Product
        //    {
        //        Id = x,
        //        Name = "asd"
        //    });
        //}

        [HttpGet]
        public IEnumerable<Product> GetProducts()
        {
            return ProductContext.Products;
        }
    }
}

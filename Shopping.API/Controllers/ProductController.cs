using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using Shopping.API.Data;
using Shopping.API.Models;
using Shopping.Client.Data;

namespace Shopping.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        private readonly ApplicationDbContext _context;

        public ProductController(ILogger<ProductController> logger, ApplicationDbContext dbContext)
        {
            _logger = logger;
            _context = dbContext;
            
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
        public async Task< IEnumerable<Product>> GetProducts()
        {
            return await _context.Products.Find(p => true).ToListAsync();
           // return ProductContext.Products;
        }
    }
}

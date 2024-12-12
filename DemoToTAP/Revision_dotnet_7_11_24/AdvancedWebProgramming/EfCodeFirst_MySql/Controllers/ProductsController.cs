using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EfCodeFirst_MySql.Data;
using EfCodeFirst_MySql.Models;
using Microsoft.EntityFrameworkCore;


namespace EfCodeFirst_MySql.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly AppDbContext _appdbContext;
        public ProductsController(AppDbContext appdbContext) {

            _appdbContext = appdbContext;
        }

        [HttpPost]

        public async Task<IActionResult> AddProduct(Product product)
        {
             _appdbContext.products.Add(product);
            _appdbContext.SaveChangesAsync();

            return Ok(product);

        }

        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            List<Product> prds = await _appdbContext.products.ToListAsync();
            return Ok(prds);
        }
    }
}

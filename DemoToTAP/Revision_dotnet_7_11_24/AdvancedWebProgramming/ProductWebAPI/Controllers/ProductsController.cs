using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Query.Internal;
using ProductWebAPI.Data;
using ProductWebAPI.Models;

namespace ProductWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ProductDbContext _dbcontext;
        public ProductsController(ProductDbContext dbContext) { 
            _dbcontext = dbContext; 
        }
        [Authorize]

        [HttpGet]
        [Route("all")]
        public async Task<IActionResult> GetAll() {
        
            List<Product> products = await _dbcontext.FlowersCatalog.ToListAsync();
            return Ok(products);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            Product prd = await _dbcontext.FlowersCatalog.FirstOrDefaultAsync(x => x.Id == id);

            return Ok(prd);
        }

        [HttpPost]
        public async Task<IActionResult> Add(Product product)
        {
            _dbcontext.FlowersCatalog.Add(product);
            await _dbcontext.SaveChangesAsync();    

            return Ok(product);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id,Product product)
        {
            _dbcontext.FlowersCatalog.Update(product);
            await _dbcontext.SaveChangesAsync();
            return Ok(product);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            Product prd = _dbcontext.FlowersCatalog.FirstOrDefault(x => x.Id == id);
            _dbcontext.FlowersCatalog.Remove(prd);
            await _dbcontext.SaveChangesAsync();
            return Ok();
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductContext_WebAPI.Data;
using ProductContext_WebAPI.Models;

namespace ProductContext_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GadgetsController : ControllerBase
    {
        private readonly GadgetsDbContext _dbcontext; 

        public GadgetsController(GadgetsDbContext dbContext) {

            _dbcontext = dbContext;
        }

        [HttpGet]
        [Route("all")]
        public async Task<IActionResult> GetAll()
        {

            List<Product> products = await _dbcontext.Gadgets.ToListAsync();

            return Ok(products);

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            Product product = await _dbcontext.Gadgets.FirstOrDefaultAsync(x => x.Id == id);
            return Ok(product);

        }

        [HttpPost]
        public async Task<IActionResult> Insert(Product product)
        {
             _dbcontext.Gadgets.Add(product); 
            await _dbcontext.SaveChangesAsync();

            return Ok(product);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Edit(int id,Product product)
        {
            _dbcontext.Gadgets.Update(product);
            await _dbcontext.SaveChangesAsync();    

            return Ok(product);

        }

        [HttpDelete("{id}")]

        public async Task<IActionResult> Delete(int id)
        {
            Product product = _dbcontext.Gadgets.FirstOrDefault(x => x.Id == id);
            if(product != null)
            {
                _dbcontext.Gadgets.Remove(product);
                await _dbcontext.SaveChangesAsync();
            }

            return Ok();    
        }

    }
}

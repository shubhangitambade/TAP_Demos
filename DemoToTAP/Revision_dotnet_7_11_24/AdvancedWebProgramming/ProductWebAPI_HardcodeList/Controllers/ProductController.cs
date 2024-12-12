using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductWebAPI_HardcodeList.Services;
using ProductWebAPI_HardcodeList.Model;

namespace ProductWebAPI_HardcodeList.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService) { 
        
            _productService = productService;
        }
        [HttpGet]
        [Route("all")]
        public IActionResult GetAll()
        {

            List<Product> products = _productService.GetProductList();

            return Ok(products);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(int id)
        {
            Product product = _productService.GetProduct(id);
            return Ok(product);
        }

        [HttpPost]

        public IActionResult Add(Product product )
        {
            _productService.Insert(product);
            return Ok(product);
        }

        [HttpPut("{id}")]
        public IActionResult Edit(Product product)
        {
            _productService.Update(product);
            return Ok(product);
        }
        [HttpDelete("{id}")]
        public IActionResult Remove(int id)
        {
            _productService.Delete(id);
            return Ok();
        }

    }
}

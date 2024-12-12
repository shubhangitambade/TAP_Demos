using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Product_MVC_Project.Models;
using Product_MVC_Project.Services;

namespace Product_MVC_Project.Controllers
{
    
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [Authorize]
        public async Task <IActionResult> Index()
        {
            List<Product> products = await _productService.GetAll();
            ViewData["prds"] = products;

            return View();
        }

        public async Task<IActionResult> GetById(int id)
        {
            Product product = await _productService.GetById(id);

            ViewData["prd"] = product;

            return View();
        }

        public async Task<IActionResult> GetByName(string name)
        {
            Product product = await _productService.GetByName(name);
            ViewData["prdByName"] = product;

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(Product product)
        {
            await _productService.Insert(product);
            return View();
        }


        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            Product theProduct =await _productService.GetById(id);
            return View(theProduct);
            
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Product product)
        {
            await _productService.Update(product);
            //return View("Index");
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int id)
        {
            await _productService.Remove(id);
            //return View("Index");

            return RedirectToAction("Index");
        }
    }
}

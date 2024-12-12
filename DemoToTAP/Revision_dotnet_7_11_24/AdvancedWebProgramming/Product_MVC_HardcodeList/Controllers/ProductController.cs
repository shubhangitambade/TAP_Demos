using Microsoft.AspNetCore.Mvc;
using Product_MVC_HardcodeList.Services;
using Product_MVC_HardcodeList.Models;
using Microsoft.AspNetCore.Authorization;

namespace Product_MVC_HardcodeList.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService) //Constructor Level DI
        {
            _productService = productService;
        }
        [Authorize]
        public IActionResult Index()
        {
            List<Product> products = _productService.GetAll();
            ViewData["prds"] = products;
            return View();
        }

        public IActionResult Details(int id)
        {
            Product product = _productService.GetById(id);
            //ViewData["prd"] = product;
            return View(product);
        }
        [HttpGet]
        public IActionResult Add() {
            return View();
        }

        public IActionResult Add(Product product) { 
        
            _productService.Insert(product);

            return RedirectToAction("Index");
        
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Product product= _productService.GetById(id);
            if(product != null)
            {
                return View(product);
            }

            return View();
        }

        [HttpPost]

        public IActionResult Edit(Product product)
        {
            _productService.Update(product);
            return RedirectToAction("Index");

        }

        public IActionResult Delete(int id)
        {
            _productService.Delete(id);

            return RedirectToAction("Index");
        }
    }
}

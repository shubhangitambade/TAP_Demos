using Microsoft.AspNetCore.Mvc;
using ECommerce_MVC_Application.Models;
using ECommerce_MVC_Application.Services;
using Microsoft.AspNetCore.Authorization;
namespace ECommerce_MVC_Application.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [Authorize]
        public IActionResult Index()
        {
            List<Product> products = _productService.GeAll();
            ViewData["prds"] = products;    
            return View();
        }

        public IActionResult Get(int id)
        {
            Product product = _productService.GetById(id);

            ViewData["prd"] = product;
            return View();
        }

        public IActionResult Remove(int id) {

            _productService.Delete(id);

            return RedirectToAction("Index");  
        }

        [HttpGet]
        public IActionResult Add() { 
        
        
            return View();
        }

        [HttpPost]

        public IActionResult Add(Product product)
        {
            _productService.Insert(product);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
           Product prd =  _productService.GetById(id);

            return View(prd);
        }

        [HttpPost]

        public IActionResult Edit(Product product)
        {
            _productService.Update(product);

            return RedirectToAction("Index");   
        }

    }
}

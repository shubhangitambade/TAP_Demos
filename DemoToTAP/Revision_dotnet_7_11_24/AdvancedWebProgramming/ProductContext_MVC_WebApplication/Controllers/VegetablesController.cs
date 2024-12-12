using Microsoft.AspNetCore.Mvc;
using ProductContext_MVC_WebApplication.Models;
using ProductContext_MVC_WebApplication.Data;
using Microsoft.AspNetCore.Authorization;


namespace ProductContext_MVC_WebApplication.Controllers
{
    public class VegetablesController : Controller
    {
        private VegetableDbContext _dbContext;

        public VegetablesController(VegetableDbContext dbContext) //DI
        {
            _dbContext = dbContext;
        }
        [Authorize]
        public IActionResult Index()
        {
            List<Product> products = _dbContext.vegetables.ToList();
            ViewData["veges"] = products;   
            return View();
        }

        public IActionResult Details(int id)
        {
            Product product = _dbContext.vegetables.FirstOrDefault(x => x.Id == id);
            return View(product);
        }
        
        public IActionResult Delete(int id)
        {
            Product product = _dbContext.vegetables.FirstOrDefault(x=>x.Id == id);
            _dbContext.vegetables.Remove(product);  
            _dbContext.SaveChanges();   

            return RedirectToAction("Index");
        }

        [HttpGet]

        public IActionResult Add() {

            return View();
        }

        [HttpPost]
        public IActionResult Add(Product product)
        {
            _dbContext.vegetables.Add(product);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpGet]

        public IActionResult Edit(int id)
        {
            Product prd = _dbContext.vegetables.SingleOrDefault(x => x.Id == id);
            return View(prd);
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            
            
            _dbContext.vegetables.Update(product);  
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Product_MVCWebApplication.Data;
using Product_MVCWebApplication.Models;

namespace Product_MVCWebApplication.Controllers
{
    public class FlowersController : Controller
    {
        private readonly ProductDbContext _dbContext;
        public FlowersController(ProductDbContext dbContext){
            _dbContext = dbContext;
        }
        [Authorize]
        public IActionResult Index()
        {
            List<Product> products = _dbContext.flowers.ToList();
            ViewData["Flowers"] = products;
            return View();
        }

        public IActionResult Details(int id) 
        {
            Product product = _dbContext.flowers.FirstOrDefault(x => x.Id == id);
            ViewData["Flower"] = product;

            return View(product);

        }
        [HttpGet]
        public IActionResult Insert()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Insert(Product product) 
        {
            
            _dbContext.flowers.Add(product);
            _dbContext.SaveChanges();
            //turn Ok(product);

            return RedirectToAction("Index", "Flowers");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Product prd = _dbContext.flowers.FirstOrDefault(y => y.Id == id);
            return View(prd);
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {

            _dbContext.flowers.Update(product);
            _dbContext.SaveChanges();
            //turn Ok(product);

            return RedirectToAction("Index", "Flowers");
        }

        [HttpGet]
        public IActionResult Delete(int id) {

            Product prd = _dbContext.flowers.FirstOrDefault(x => x.Id == id);

            _dbContext.Remove(prd);
            _dbContext.SaveChanges();

            return RedirectToAction("Index", "Flowers");
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using StateManagement.Services;
using StateManagement.Models;
using StateManagement.Helper;

namespace StateManagement.Controllers
{
    public class FlowerCartController : Controller
    {
        const string SessionKeyTime = "_Time";

        private readonly IFlowerService _flowerService;
        public FlowerCartController(IFlowerService flowerService)
        {
            _flowerService = flowerService;
        }
        public IActionResult Index()
        {
            Cart theCart = SessionHelper.GetObjectFromJson<Cart>(HttpContext.Session, "cart");
            return View(theCart);
           
        }

        [HttpGet]
        public IActionResult Add(int id)
        {
            Flower theFlower = _flowerService.GetById(id);
            Item theItem = new Item();
            theItem.theFlower = theFlower;
            theItem.Quantity = 0;
            return View(theItem);
        }

        [HttpPost]
        public IActionResult Add(Item newItem)
        {

            var currentTime = DateTime.Now;
            // if (HttpContext.Session.Get<DateTime>(SessionKeyTime) == default)
            {
                //  HttpContext.Session.Set<DateTime>(SessionKeyTime, currentTime);
            }
            //Console.WriteLine("Current Time: {Time}", currentTime);
            //Console.WriteLine("Session Time: {Time}", HttpContext.Session.Get<DateTime>(currentTime));

            Cart theCart = null;

            theCart = SessionHelper.GetObjectFromJson<Cart>(HttpContext.Session, "cart");
            if (theCart == null)
            {
                theCart = new Cart();
            }
            theCart.Items.Add(newItem);
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", theCart);
            return RedirectToAction("Index", "FlowerCart");
        }

        public IActionResult Remove(int id)
        {
            Cart theCart = SessionHelper.GetObjectFromJson<Cart>(HttpContext.Session, "cart");
            var found = theCart.Items.Find(x => x.theFlower.Id== id);
            if (found != null) theCart.Items.Remove(found);
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", theCart);
            return RedirectToAction("Index", "FlowerCart");
        }

    }
}

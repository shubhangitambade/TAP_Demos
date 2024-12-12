using Microsoft.AspNetCore.Mvc;

namespace StateManagement.Controllers
{
    public class ShoppingCartController : Controller
    {

        //Show all products in cart
        public IActionResult Index()
        {

            //get Value from session Variable
            string sessionData = HttpContext.Session.GetString("product");
            Console.WriteLine("Session data is retrived from server " + sessionData);
            HttpContext.Session.SetString("product", "laptop");

            return View();
        }

        //Add id as new item into Cart
        public IActionResult AddToCart(int id)
        {
            //change value in session variable
            HttpContext.Session.SetString("product", "laptop" + id);
            Console.WriteLine("Session data is added to server side");
            return RedirectToAction("Index");
        }

    }
}

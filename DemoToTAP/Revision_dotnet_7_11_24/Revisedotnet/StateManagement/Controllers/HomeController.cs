using Microsoft.AspNetCore.Mvc;
using StateManagement.Models;
using System.Diagnostics;

namespace StateManagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //read cookie from Request object  
            string userName = Request.Cookies["UserName"];
            return View("Index", userName);
            
        }

        [HttpPost]
        public IActionResult Index(IFormCollection form)
        {
            string userName = form["userName"].ToString();
            //set the key value in Cookie              
            CookieOptions option = new CookieOptions();
            option.Expires = DateTime.Now.AddMinutes(10);
            Response.Cookies.Append("UserName", userName, option);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult RemoveCookie()
        {
            //Delete the cookie            
            Response.Cookies.Delete("UserName");
            return View("Index");
        }
    }
}

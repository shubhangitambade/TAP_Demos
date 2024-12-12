using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using ProductWebAPI.Models;
using System.Security.Claims;
namespace ProductWebAPI.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Login(User user)
        {
            if(user!= null)
            {
                if(user.Email == "shubhangi.t@gmail.com" &&  user.Password == "tfl@123")
                {   
                    //Step 3
                    //Create Claim Identity
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, user.Email)
                    };

                    var claimIdentity = new ClaimsIdentity(claims,CookieAuthenticationDefaults.AuthenticationScheme);
                    var claimPrincipal = new ClaimsPrincipal(claimIdentity);

                    HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimPrincipal);
                }
            }
            return View();
        }

        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Account");
        }

    }
}

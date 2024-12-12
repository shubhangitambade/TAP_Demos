using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;

using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Product_MVCWebApplication.Models;
using System.Security.Claims;


namespace Product_MVCWebApplication.Controllers
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
            if(user !=null)
            {
                if(user.Email == "shubhangi.t@gmail.com" && user.Password == "password")
                {
                    //Create Claim Identity
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name,user.Email)
                    };
                    var claimIdentity = new ClaimsIdentity(claims,CookieAuthenticationDefaults.AuthenticationScheme);
                    var calimPrincipal= new ClaimsPrincipal(claimIdentity);

                    HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, calimPrincipal); 
                    return RedirectToAction("Index", "Flowers");
                }
            }
            return View(user);
        }

        public IActionResult Logout()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return RedirectToAction("Login", "Account");
            
        }
    }
}

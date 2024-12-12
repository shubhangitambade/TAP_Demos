using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Product_MVC_HardcodeList.Models;
using System.Security.Claims;

namespace Product_MVC_HardcodeList.Controllers
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
            if (user != null)
            {
                if(user.Email == "shubhangi.t@gmail.com" && user.Password == "password")
                {
                    //Create Claim
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name,user.Email)
                    };

                    var claimIdentity = new ClaimsIdentity(claims,CookieAuthenticationDefaults.AuthenticationScheme);
                    var claimPrincipal = new ClaimsPrincipal(claimIdentity);

                    HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,claimPrincipal);
                }
            }
            return View();
        }

        [HttpPost]

        public IActionResult Logout()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login","Account");
        }
    }
}

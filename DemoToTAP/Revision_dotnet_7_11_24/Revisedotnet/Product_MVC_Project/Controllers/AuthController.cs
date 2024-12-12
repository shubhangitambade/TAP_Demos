using Microsoft.AspNetCore.Mvc;
using Product_MVC_Project.Services;
using Product_MVC_Project.Models;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace Product_MVC_Project.Controllers
{
    public class AuthController : Controller
    {
        private readonly IUserService _userService;

        public AuthController(IUserService userService)
        {
            _userService = userService; //Dependency Injection
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]

        public async Task<IActionResult> Login(string email,string password )
        {
            var user = await _userService.ValidateUser(email,password);

            if (user != null)
            {
                //Create Claims Identity
                var claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.Name,email)
                };

                var claimsIdentity = new ClaimsIdentity(claims,CookieAuthenticationDefaults.AuthenticationScheme);
                var claimsPrinciple = new ClaimsPrincipal(claimsIdentity);

                // Sign in the user
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimsPrinciple);

                return RedirectToAction("Index", "Product");

            }
            return View("Login");
        }


        public async Task<IActionResult> Logout()
        {
            //Sign Out the user
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Auth");
        }
    }
}

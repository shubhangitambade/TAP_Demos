using Microsoft.AspNetCore.Mvc;
using EmployeDbContext.Models;
using Microsoft.AspNetCore.Authentication;
using EmployeDbContext.Services;
using System.Security.Claims;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace EmployeDbContext.Controllers
{
    public class LoginController : Controller,IAuthenticationService
    {
        private readonly UserService _userService;

        public LoginController(UserService userService)
        {
            _userService = userService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> LogIn(string username,string password)
        {
            User user = _userService.UserValidate(username, password);

            Console.WriteLine("User : " + user);
            if(user!=null)
            {
                //Create a Claim Identity

                var claims = new List<Claim>
                {
                     new Claim(ClaimTypes.Name, username)
                };

                var claimsIdentity = new ClaimsIdentity(claims,
                                                       CookieAuthenticationDefaults.AuthenticationScheme);
                var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

                // Sign in the user
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                                              claimsPrincipal);

                
                return RedirectToAction("Index","Employee");
            }
            return View("Login");
        }

        public async Task<IActionResult> Logout()
        {

            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("LogIn", "Login");
        }

        public bool IsAutheticated(User user)
        {
            bool status = false;

            if(user.Uname == null || user.Password == null)
            {
                return status;
            }
            else
            {
                if(user.Uname == "Ravi" && user.Password == "tfl@123")
                status = true;
                return status;
            }
        }

        public Task<AuthenticateResult> AuthenticateAsync(HttpContext context, string? scheme)
        {
            throw new NotImplementedException();
        }

        public Task ChallengeAsync(HttpContext context, string? scheme, AuthenticationProperties? properties)
        {
            throw new NotImplementedException();
        }

        public Task ForbidAsync(HttpContext context, string? scheme, AuthenticationProperties? properties)
        {
            throw new NotImplementedException();
        }

        public Task SignInAsync(HttpContext context, string? scheme, ClaimsPrincipal principal, AuthenticationProperties? properties)
        {
            throw new NotImplementedException();
        }

        public Task SignOutAsync(HttpContext context, string? scheme, AuthenticationProperties? properties)
        {
            throw new NotImplementedException();
        }
    }
}

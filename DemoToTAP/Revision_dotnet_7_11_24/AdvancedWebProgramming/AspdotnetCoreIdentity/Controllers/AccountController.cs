using Microsoft.AspNetCore.Mvc;
using AspdotnetCoreIdentity.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace AspdotnetCoreIdentity.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()  //string ReturnUrl = "/"
        {
           // LoginViewModel objLoginModel = new LoginViewModel();
            //objLoginModel.ReturnUrl = ReturnUrl;
            return View();
        }
        [HttpPost]
       
        public IActionResult Login(LoginViewModel model) //, string? ReturnUrl
        {
            if(ModelState.IsValid)
            {
                if(model.Email == "shubhangi.t@gmail.com" && model.Password == "tfl@123")
                {

                    /*If credentials are correct create a ClaimsIdentity with the required Claims. Call the SignInAsync to sign in the user.
                    
                       Once the user is successfully logged in to the application, a cookie will be generated(you can see it in Applcation tab Cookies option of developer tool 
                        This encrypted cookie will be sent to the server in each request and validated on the server with its key.
                     */

                    // Create a claims identity
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, model.Email)
                    };
                    var claimsIdentity = new ClaimsIdentity(claims,
                                                            CookieAuthenticationDefaults.AuthenticationScheme);
                    var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                    // Sign in the user
                    HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimsPrincipal);
                    return RedirectToAction("Index", "Home"); 
                }
            }

            return View();
        }
        
        /*Logout link is shown to the user who is already signed in. On Clicking on the Logout link, 
         * we are calling the SignOutAsync method which signs out the user and deletes their cookie.*/
        public IActionResult Logout()
        {
              HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
             return RedirectToAction("Index", "Home");
        }

    }
}

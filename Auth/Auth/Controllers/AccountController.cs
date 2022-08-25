using Auth.Filters;
using Auth.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using System;
using System.Linq;

namespace Auth.Controllers
{
    [AllowAnonymous]
    public class AccountController : Controller
    {
        
        public IActionResult Login()
        {
            // Set and Get cookies
            CookieOptions cookieOptions = new CookieOptions();
            cookieOptions.Expires = new DateTimeOffset(DateTime.Now.AddDays(7));

            HttpContext.Response.Cookies.Append("first_request", DateTime.Now.ToString(), cookieOptions);
            var setCookieHeaders = HttpContext.Response.GetTypedHeaders().SetCookie;

            // We assume only one cookie is found. You could loop over multiple matches instead.
            // setCookieHeaders may be null if response doesn't contain set-cookie headers
            var cookie = setCookieHeaders?.FirstOrDefault(x => x.Name == "first_request");

            
            return View();
        }


        [HttpPost]        
        public IActionResult Login(UserLogin userInfo)
        {
            var userName = userInfo.UserName;
            var password = userInfo.Password;
            if (!string.IsNullOrEmpty(userName) && string.IsNullOrEmpty(password))
            {
                return RedirectToAction("Login");
            }

            //Check the user name and password  
            //Here can be implemented checking logic from the database  
            ClaimsIdentity identity = null;
            bool isAuthenticated = false;

            if (userName == "Admin" && password == "password")
            {

                //Create the identity for the user  
                identity = new ClaimsIdentity(new[] {
                    new Claim(ClaimTypes.Name, userName),
                    new Claim(ClaimTypes.Role, "Admin")
                }, CookieAuthenticationDefaults.AuthenticationScheme);

                isAuthenticated = true;
            }

            if (userName == "Reception" && password == "password")
            {
                //Create the identity for the user  
                identity = new ClaimsIdentity(new[] {
                    new Claim(ClaimTypes.Name, userName),
                    new Claim(ClaimTypes.Role, "User")
                }, CookieAuthenticationDefaults.AuthenticationScheme);

                isAuthenticated = true;
            }

            if (isAuthenticated)
            {
                var principal = new ClaimsPrincipal(identity);

                var login = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

                return RedirectToAction("Index", "Home");
            }

            ViewBag.ErrorMessage = "Please enter valid user name and password";
            return View();
        }

        
        [HttpPost]
        public IActionResult Logout()
        {
            var login = HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login");
        }
    }
}

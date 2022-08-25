using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using UserManagement.Filters;
using UserManagement.Models;

namespace UserManagement.Controllers
{

    [Authorize(Roles = "Owner")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            // Add the information into cookie
            CookieOptions cookieOptions = new CookieOptions();
            cookieOptions.Expires = new DateTimeOffset(DateTime.Now.AddDays(7));
            HttpContext.Response.Cookies.Append("loggedin_user_name", User.Identity.Name, cookieOptions);


            //Retrieve cookie value
            var setCookieHeaders = HttpContext.Response.GetTypedHeaders().SetCookie;
            var cookie = setCookieHeaders?.FirstOrDefault(x => x.Name == "loggedin_user_name");
            ViewBag.UserName = cookie?.Value;

            ViewData["RoleName"] = User.FindFirst(claim => claim.Type == System.Security.Claims.ClaimTypes.Role)?.Value;
            TempData["RoleName"] = ViewData["RoleName"];
            return RedirectToAction("Privacy");
        }

        [AllowAnonymous]
        public IActionResult Privacy()
        {
            ViewData["RoleName"] = TempData["RoleName"];
            TempData.Keep();
            TempData.Peek("RoleName");
            return View();
        }

      


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

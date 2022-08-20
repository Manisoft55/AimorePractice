using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCFilters.Filters;
using MVCFilters.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVCFilters.Controllers
{
    [ExceptionHandling]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [CustomAuthorizationFilter]
        [CustomResourceFilterAttribute]
        [RoleAccess]
        [CustomResultFilter]
        public IActionResult ReturnResult()
        {
            var obj = new { Success = true, Message = "Success" };
            try
            {
                
                int j = 0;
                int t = 123 / j;
            }
            catch (Exception ex)
            {
                throw ex;
            }
           
            return new JsonResult(obj);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

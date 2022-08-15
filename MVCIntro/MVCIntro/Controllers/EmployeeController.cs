using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCIntro.Models;

namespace MVCIntro.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ILogger<EmployeeController> _logger;

        public EmployeeController(ILogger<EmployeeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        
        [HttpPost]
        public IActionResult Index(Employee employee)
        {
            return View();
        }
    }
}

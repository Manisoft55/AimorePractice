using Microsoft.AspNetCore.Mvc;

namespace MVCApplication.Controllers
{
    [Route("Inventory")]
    public class InventoryManagementController : Controller
    {
        [Route("")]
        [Route("FirstPage")]
        [Route("SecondPage")]
        public IActionResult Index()
        {
            return View();
        }
    }
}

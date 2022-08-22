using Microsoft.AspNetCore.Mvc;

namespace UserManagement.Controllers
{
    public class UserInfoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult UserRegistration()
        {
            return View();
        }

        public IActionResult UserCreation()
        {
            return View();
        }
    }
}

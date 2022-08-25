using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using UserManagement.Filters;

namespace UserManagement.Controllers
{
    [Authorize(Roles = "Owner,User")]
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

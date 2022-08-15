using Microsoft.AspNetCore.Mvc;

namespace MVCApplication.Controllers
{
    public class LearningController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MontlyLearning()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace MVCIntro.Controllers
{
    [Route("[controller]")]
    public class StudentController : Controller
    {
        [Route("Index")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("")]
        [Route("StudentEmpty")]
        [ActionName("Std")]
        public ActionResult StudentEmpty()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using MVCApplication.Models;
using System;

namespace MVCApplication.Controllers
{
    public class LearningController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult EmptyActionMethod()
        {
            return new EmptyResult();
        }

        public IActionResult ReturnJsonResult()
        {
            return RedirectToAction("MontlyLearning");
            var errorModel = new ErrorViewModel();
            errorModel.RequestId = "RequestId";
            return new JsonResult(errorModel);
        }

        public int Addition()
        { 
            return 5 + 5; 
        }

        [NonAction]
        public int AdditionTwo()
        {
            return 20;
        }
       
        //[ActionName("MontlyLearningActionMethod")]
        public IActionResult MontlyLearning()
        {
            return View();
        }
    }
}

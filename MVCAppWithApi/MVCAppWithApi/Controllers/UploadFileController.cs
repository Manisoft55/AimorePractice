using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVCAppWithApi.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MVCAppWithApi.Controllers
{
    public class UploadFileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(List<IFormFile> files)
        {
            string path = @"D:\Aimore\Projects\MVCAppWithApi\MVCAppWithApi\";
            long size = files.Sum(f => f.Length);

            var filePaths = new List<string>();
            foreach (var formFile in files)
            {
                if (formFile.Length > 0)
                {

                    // full path to file in temp location
                    var filePath = path + formFile.FileName; //we are using Temp file name just for the example. Add your own file path.
                    filePaths.Add(filePath);
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await formFile.CopyToAsync(stream);
                    }
                }
            }
            // process uploaded files
            // Don't rely on or trust the FileName property without validation.
            return Ok(new { count = files.Count, size, filePaths });
        }

        public IActionResult RadioButton()
        {
            var vm = new UserModelForRadio();
            vm.Roles = new List<RoleVm>
                {
                    new RoleVm {Id = 1, RoleName = "Admin"},
                    new RoleVm {Id = 2, RoleName = "Editor"},
                    new RoleVm {Id = 3, RoleName = "Reader"}
                };

            List<SelectListItem> cities = new List<SelectListItem>()
            {
                new SelectListItem { Value = "1", Text = "Latur" },
                new SelectListItem { Value = "2", Text = "Solapur" },
                new SelectListItem { Value = "3", Text = "Nanded" },
                new SelectListItem { Value = "4", Text = "Nashik" },
                new SelectListItem { Value = "5", Text = "Nagpur" },
                new SelectListItem { Value = "6", Text = "Kolhapur" },
                new SelectListItem { Value = "7", Text = "Pune" },
                new SelectListItem { Value = "8", Text = "Mumbai" },
                new SelectListItem { Value = "9", Text = "Delhi" },
                new SelectListItem { Value = "10", Text = "Noida" }
            };

            //assigning SelectListItem to view Bag
            ViewBag.cities = cities;
            return View(vm);
        }


    }
}

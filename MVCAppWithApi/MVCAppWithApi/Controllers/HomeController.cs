using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCAppWithApi.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MVCAppWithApi.Controllers
{
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

        public IActionResult EmployeeList()
        {
            HttpClient httpClient = new HttpClient();
            var response = httpClient.GetAsync("https://localhost:44304/Employee/AllEmployee").Result;
            var responseArray = response.Content.ReadAsStringAsync().Result;
            List<EmployeeInfo> employees = JsonConvert.DeserializeObject<List<EmployeeInfo>>(responseArray);
            return View(employees);
        }

        public IActionResult ViewEmployee(int empid)
        {
            HttpClient httpClient = new HttpClient();
            var response = httpClient.GetAsync("https://localhost:44304/Employee/SelectEmployee?employeeId="+empid).Result;
            var responseArray = response.Content.ReadAsStringAsync().Result;
            List<EmployeeInfo> employees = JsonConvert.DeserializeObject<List<EmployeeInfo>>(responseArray);
            return View(employees[0]);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

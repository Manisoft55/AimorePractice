using Microsoft.AspNetCore.Mvc;
using MVCExample.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;

namespace MVCExample.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult ViewEmployee()
        {
            //var respList = new List<EmployeeInfo>();
            //using(HttpClient httpClient = new HttpClient())
            //{
            //    var result = httpClient.GetAsync("https://localhost:44304/employee/allemployee").Result;
            //    var response = result.Content.ReadAsStringAsync().Result;
            //    respList = JsonConvert.DeserializeObject<List<EmployeeInfo>>(response);
            //}
            //return View(respList);
            return View();
        }



        public IActionResult SelectEmployee()
        {

            //var respList = new List<EmployeeInfo>();
            //using (HttpClient httpClient = new HttpClient())
            //{
            //    var result = httpClient.GetAsync("https://localhost:44304/employee/allemployee").Result;
            //    var response = result.Content.ReadAsStringAsync().Result;
            //    respList = JsonConvert.DeserializeObject<List<EmployeeInfo>>(response);
            //}
            //return View(respList);

            //var respList = new List<EmployeeInfo>();
            //using (HttpClient httpClient = new HttpClient())
            //{
            //    var result = httpClient.GetAsync("https://localhost:44304/employee/allemployee").Result;
            //    var response = result.Content.ReadAsStringAsync().Result;
            //    respList = JsonConvert.DeserializeObject<List<EmployeeInfo>>(response);
            //}
            //return View(respList);
            return View();
        }
    }
}

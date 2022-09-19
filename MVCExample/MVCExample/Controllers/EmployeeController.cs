using Microsoft.AspNetCore.Mvc;
using MVCExample.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

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
            var respList = new List<EmployeeInfo>();
            using (HttpClient httpClient = new HttpClient())
            {
                var result = httpClient.GetAsync("https://localhost:44304/employee/allemployee").Result;
                var response = result.Content.ReadAsStringAsync().Result;
                respList = JsonConvert.DeserializeObject<List<EmployeeInfo>>(response);
            }
            return View(respList);
            //return View();
        }

        public IActionResult CreateEmployee()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateEmployee(EmployeeInfo employeeInfo)
        {
            HttpClient httpClient = new HttpClient();
            employeeInfo.manager_id = 1;
            employeeInfo.department_id = 1;
            var data = new StringContent(JsonConvert.SerializeObject(employeeInfo), Encoding.UTF8, "application/json");

            var response = httpClient.PostAsync("https://localhost:44304/employee/CreateEmployee", data).Result;
            var empId = response.Content.ReadAsStringAsync().Result;
            return View();
        }

        public IActionResult UpdateEmployee(EmployeeInfo employeeInfo)
        {
            return View(employeeInfo);
        }

        [HttpPost]
        public IActionResult UpdateEmployeeInfo(EmployeeInfo employeeInfo)
        {
            HttpClient httpClient = new HttpClient();
            employeeInfo.manager_id = 1;
            employeeInfo.department_id = 1;
            var data = new StringContent(JsonConvert.SerializeObject(employeeInfo), Encoding.UTF8, "application/json");

            var response = httpClient.PutAsync("https://localhost:44304/employee/UpdateEmployee", data).Result;            
            return RedirectToAction("ViewEmployee");
        }

        //[HttpPost]
        public IActionResult DeleteEmployee(int empId)
        {
            HttpClient httpClient = new HttpClient();
            var response = httpClient.DeleteAsync("https://localhost:44304/Employee/DeleteEmployee?empId="+empId).Result;
            return RedirectToAction("ViewEmployee");
        }

        public IActionResult SelectEmployee(string empId)
        {
            HttpClient httpClient = new HttpClient();
            var response = httpClient.GetAsync("https://localhost:44304/Employee/SelectEmployee?employeeId=" + empId).Result;
            var responseArray = response.Content.ReadAsStringAsync().Result;
            List<EmployeeInfo> employees = JsonConvert.DeserializeObject<List<EmployeeInfo>>(responseArray);
            return View("ViewEmployee", employees[0]);
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
            //return View();
        }
    }
}

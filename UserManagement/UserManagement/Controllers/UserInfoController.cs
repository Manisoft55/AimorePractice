using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using UserManagement.Filters;

namespace UserManagement.Controllers
{
    [Authorize(Roles = "Owner,User")]
    public class UserInfoController : Controller
    {
        public IActionResult Index()
        {
            string sql = "select * from employees where email =@emailId";
            //string sqlUpdate = " update employees set email = " + "'emailidf@gmail.com'; delete from employees; select * from employees " + " where employee_id = " + Convert.ToString(101);
            SqlConnection connection = new SqlConnection("Data Source=MSP-LAPTOP;Initial Catalog=InstituteCmd;persist security info=True; Integrated Security = SSPI;");
            SqlConnection connectionOne = new SqlConnection("Data Source=MSP-LAPTOP;Initial Catalog=InstituteCmd;persist security info=True; Integrated Security = SSPI;");

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet ds = new DataSet();
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                //command.Parameters.Add(new SqlParameter("empid", 101));
                command.Parameters.Add(new SqlParameter("emailId", "emailidf@gmail.com; delete from employees;"));
                command.ExecuteNonQuery();
                //adapter.SelectCommand = command;
                //adapter.Fill(ds);
                adapter.Dispose();
                command.Dispose();
                connection.Close();
            }
            catch (Exception ex)
            {
                
            }
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

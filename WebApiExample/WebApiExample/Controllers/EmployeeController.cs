using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using WebApiExample.Model;

namespace WebApiExample.Controllers
{
    [ApiController]
    [Route("[controller]")]    
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        [Route("AllEmployee")]
        public List<EmployeeInfo> Get()
        {
            string sql = "select * from employees";
            SqlConnection connection = new SqlConnection("Data Source=MSP-LAPTOP;Initial Catalog=InstituteCmd;persist security info=True; Integrated Security = SSPI;");

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet ds = new DataSet();
            connection.Open();
            SqlCommand command = new SqlCommand(sql, connection);
            adapter.SelectCommand = command;
            adapter.Fill(ds);
            adapter.Dispose();
            command.Dispose();
            connection.Close();

            var myData = ds.Tables[0].AsEnumerable().Select(r => new EmployeeInfo
            {
                employee_id = r.Field<int>("employee_id"),
                first_name = r.Field<string>("first_name"),
                last_name = r.Field<string>("last_name"),
                email = r.Field<string>("email"),
                hire_date = r.Field<DateTime>("hire_date"),
                job_id = r.Field<int>("job_id"),
                phone_number = r.Field<string>("phone_number"),
                salary = r.Field<decimal>("salary"),
                manager_id = r.Field<Nullable<int>>("manager_id"),
                department_id = r.Field<Nullable<int>>("department_id")
            });
            var list = myData.ToList();
            return list;

        }

        [HttpGet]
        [Route("SelectEmployee")]
        public List<EmployeeInfo> SelectEmployee(int employeeId)
        {
            string sql = "select * from employees where employee_id = @empId";
            SqlConnection connection = new SqlConnection("Data Source=MSP-LAPTOP;Initial Catalog=InstituteCmd;persist security info=True; Integrated Security = SSPI;");

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet ds = new DataSet();
            connection.Open();
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.Add(new SqlParameter("empid", employeeId));
            adapter.SelectCommand = command;
            adapter.Fill(ds);
            adapter.Dispose();
            command.Dispose();
            connection.Close();

            var myData = ds.Tables[0].AsEnumerable().Select(r => new EmployeeInfo
            {
                employee_id = r.Field<int>("employee_id"),
                first_name = r.Field<string>("first_name"),
                last_name = r.Field<string>("last_name"),
                email = r.Field<string>("email"),
                hire_date = r.Field<DateTime>("hire_date"),
                job_id = r.Field<int>("job_id"),
                phone_number = r.Field<string>("phone_number"),
                salary = r.Field<decimal>("salary"),
                manager_id = r.Field<Nullable<int>>("manager_id"),
                department_id = r.Field<Nullable<int>>("department_id")
            });
            var list = myData.ToList();
            return list;

        }

        //[HttpGet]
        //public List<EmployeeInfo> Get(int empId)
        //{
        //    string sql = "select * from employees where employee_id = @empId";
        //    SqlConnection connection = new SqlConnection("Data Source=MSP-LAPTOP;Initial Catalog=InstituteCmd;persist security info=True; Integrated Security = SSPI;");

        //    SqlDataAdapter adapter = new SqlDataAdapter();
        //    DataSet ds = new DataSet();
        //    connection.Open();
        //    SqlCommand command = new SqlCommand(sql, connection);            
        //    command.Parameters.Add(new SqlParameter("empid", empId));
        //    adapter.SelectCommand = command;
        //    adapter.Fill(ds);
        //    adapter.Dispose();
        //    command.Dispose();
        //    connection.Close();

        //    var myData = ds.Tables[0].AsEnumerable().Select(r => new EmployeeInfo
        //    {
        //        employee_id = r.Field<int>("employee_id"),
        //        first_name = r.Field<string>("first_name"),
        //        last_name = r.Field<string>("last_name"),
        //        email = r.Field<string>("email"),
        //        hire_date = r.Field<DateTime>("hire_date"),
        //        job_id = r.Field<int>("job_id"),
        //        phone_number = r.Field<string>("phone_number"),
        //        salary = r.Field<decimal>("salary")
        //    });
        //    var list = myData.ToList();
        //    return list;

        //}

        //[HttpPost]
        //public void Post([FromBody]EmployeeInfo employeeInfo)
        //{
        //    string sql = "select * from employees where employee_id = @empId";
        //    SqlConnection connection = new SqlConnection("Data Source=MSP-LAPTOP;Initial Catalog=InstituteCmd;persist security info=True; Integrated Security = SSPI;");
        //}
    }
}

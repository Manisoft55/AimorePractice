using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POCOClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sorted List");
            SortedList<string, string> sorlist = new SortedList<string,string>();
            sorlist.Add("sakthi", "Name");
            sorlist.Add("apple", "Fruits");
            sorlist.Add("enfield", "Bike");

            foreach (var item in sorlist)
            {
                Console.WriteLine(item.Key);
            }

            Console.ReadLine();

            Console.WriteLine("List");
            List<EmployeeDetails> list = new List<EmployeeDetails>();
            for(int h = 0; h < 1000; h++)
            {
                EmployeeDetails employeeDetails1 = new EmployeeDetails();
                employeeDetails1.EmpSalary = "1000" + h;
                employeeDetails1.EmpManager = "Manager " + h.ToString();
                employeeDetails1.EmpName = "Employee"+h.ToString();
                list.Add(employeeDetails1);
            }
            Console.ReadLine();

            Console.WriteLine("Dictionary");
            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(1, "Test One");
            dic.Add(2, "Test Two");
            dic.Add(3, "Test Three");
            Console.WriteLine(dic[1]);
            foreach (var item in dic)
            {
               Console.WriteLine(item.Value);
            }
            Console.ReadLine();

            Console.WriteLine("Value type Vs Reference Type");
            int i = 400;
            Console.WriteLine(i);
            ValueType(i);
            Console.WriteLine(i);
            Console.ReadLine();

            EmployeeDetails employee = new EmployeeDetails();
            employee.EmpName = "Rajesh";
            //Console.WriteLine(employee.EmpName);
            ReferenceType(employee);
            //Console.WriteLine(employee.EmpName);
            Console.ReadLine();

            Console.WriteLine("POCO Class");
            EmployeeDetails employeeDetails = new EmployeeDetails();
            employeeDetails.EmpName = "Rajes";
            employeeDetails.EmpAge = 23;
            employeeDetails.EmpSalary = "10000";
            employeeDetails.EmpManager = "Kumar";
            Console.ReadLine();
        }

        static void ValueType(int i)
        {
            i = 200;            
        }

        static void ReferenceType(EmployeeDetails employeeDetails)
        {
            employeeDetails.EmpName = "Suresh";
        }
    }
}

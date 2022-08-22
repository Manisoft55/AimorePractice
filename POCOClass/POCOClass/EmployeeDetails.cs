using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POCOClass
{
    internal class EmployeeDetails
    {
        private string _empName;
        public string EmpName {
            set
            {
                _empName = value;
            }
        }
        public int EmpAge { get; set; }
        public string EmpManager { get; set; }
        public string EmpSalary { get; set; }
    }
}

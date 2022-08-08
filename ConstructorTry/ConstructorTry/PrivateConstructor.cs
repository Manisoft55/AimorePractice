using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorTry
{
    internal class PrivateConstructor
    {
        static PrivateConstructor()
        {
            Console.WriteLine("Static Constructor"); 
        }
        internal PrivateConstructor()
        {
            Console.WriteLine("Normal Constructor");
        }

        internal PrivateConstructor(string s)
        {
            Console.WriteLine("Parameterized Constructor");
        }
    }

    internal class CopyConstructor
    {
        internal string EmpId;
        internal string EmpName;
        private string empManager;
        
        internal string EmpManager
        {
            get { return empManager; }
            set { empManager = value; }
        }

        internal CopyConstructor(string empId, string empName)
        {
            this.EmpId = empId;
            this.EmpName = empName;
        }

        internal CopyConstructor(CopyConstructor copyConstructor)
        {
            Console.WriteLine("Calling from Copy constructor");
            EmpId = copyConstructor.EmpId;
            EmpName = copyConstructor.EmpName;
        }

    }
}

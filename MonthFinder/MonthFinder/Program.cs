using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonthFinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter month number");
            string inputstring=Console.ReadLine();
            FindMonth obj=new FindMonth();
            string monthname =obj.ReturnMonthName(Convert.ToInt32(inputstring));
            Console.WriteLine(monthname);
            Console.ReadLine();
        }
    }
}

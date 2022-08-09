using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your date of birth e.g 10/30/1876");
            DateTime dob = DateTime.Parse(Console.ReadLine());
            var result = DateTime.Now - dob;
            Console.WriteLine(result.Days + " Days");
            Console.ReadLine();
        }
    }
}

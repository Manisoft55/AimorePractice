using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Abstraction");
            Console.WriteLine("Please enter the number");
            AdditionClass additionClass = new AdditionClass();
            
            var result = additionClass.AddMyValueWithHundred(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Result : " + result);
            Console.ReadLine();

            PropertySet set = new PropertySet();
            set.Property = 5;
            set.PropertyOne = 10;
            Console.WriteLine("Get example " + set.PropertyTwo);
            Console.ReadLine();
        }
    }
}

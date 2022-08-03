using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAccessModifier;

namespace MethodOverloading
{
    internal class Program 
    {
        static void Main(string[] args)
        {

            Class1 objclass = new Class1();

            Console.WriteLine("Method Overloading");
            MethodOverloadExample example = new MethodOverloadExample();
            MethodOverloadExample exampleOne = new MethodOverloadExample();
            //var result = example.Addition(4, 5);

            Decimal numberOne = 123.2343243242342M;
            Decimal numberTwo = 1321312.23222M;
            var result = example.Addition(numberOne, numberTwo);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    internal class MethodOverloadExample
    {
        protected void TestMethod()
        {

        }
        public int Addition(int numberOne, int numberTwo)
        {
            Console.WriteLine("int method");
            return numberOne + numberTwo;
        }

        public float Addition(float numberOne, float numberTwo)
        {
            Console.WriteLine("float method");
            return numberOne + numberTwo;
        }

        public decimal Addition(decimal numberOne, decimal numberTwo)
        {
            Console.WriteLine("decimal method");
            return numberOne + numberTwo;
        }
    }
}

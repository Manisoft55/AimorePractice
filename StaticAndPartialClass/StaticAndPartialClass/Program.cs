using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticAndPartialClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var res = StaticClassExample.ConvertToString(10);
            int val = 100;
            string resultVal = val.ConvertToString();
            Console.WriteLine("Please enter the number for " + StaticClassExample.AdditionLabel);
            float fltNumber = float.Parse(Console.ReadLine());
            var result = StaticClassExample.AddNumberWithPiValue(fltNumber);
            Console.WriteLine("Float Value " + result);
            Console.ReadLine();

            StaticClass.ReturnStaticMethod();
            StaticClass staticClass = new StaticClass();
            staticClass.NormalMethod();
            Console.ReadLine();

            Console.WriteLine("Partial Class");
            PartialClass partialClass = new PartialClass();
            partialClass.ReturnPartialString();
            partialClass.ReturnPartialStringFromFirstInstance();
            partialClass.ReturnPartialStringFromSecondInstance();
            Console.ReadLine();

        }
    }
}

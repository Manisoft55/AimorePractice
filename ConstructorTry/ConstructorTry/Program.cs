using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorTry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrivateConstructor privateConstructor = new PrivateConstructor();
            PrivateConstructor privateConstructorOne = new PrivateConstructor();
            Console.ReadLine();
            Console.WriteLine("Copy Constructor");
            CopyConstructor copyConstructor = new CopyConstructor("Emp001", "Mani");
            copyConstructor.EmpManager = "Test";
            CopyConstructor copyConstructor1 = new CopyConstructor(copyConstructor);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorExample
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Copy Constructor");
            CopyConstructor copy = new CopyConstructor("Test", "45");
            Console.WriteLine(copy.name); 
            Console.WriteLine(copy.age);

            Console.WriteLine("**********************************");
            CopyConstructor copyOne = new CopyConstructor(copy);
            Console.WriteLine(copyOne.name);
            Console.WriteLine(copyOne.age);
            Console.ReadLine();

            int i = 0;
            i = 10;
            Console.WriteLine("StaticConstructorClass");
            StaticConstructorClass staticConstructorClass = new StaticConstructorClass();
            StaticConstructorClass staticConstructorClass1 = new StaticConstructorClass();
            Console.ReadLine();

            Console.WriteLine("Constructor");
            ConstrctorExample constrctorExample = new ConstrctorExample(Console.ReadLine());


            Console.WriteLine(constrctorExample.ReturnName());
            Console.ReadLine();
        }
    }
}

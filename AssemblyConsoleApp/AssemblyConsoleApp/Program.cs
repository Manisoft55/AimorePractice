using AssemblyPrivate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AssemblyConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Assembly");
            AssemblyPrivateClass obj = new AssemblyPrivateClass();
            Console.WriteLine(obj.ReturnAssemblyVersion());
            Console.ReadLine();
        }
    }
}

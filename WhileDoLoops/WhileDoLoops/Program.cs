using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileDoLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("While Loop");
            WhileLoop whileLoop = new WhileLoop();
            whileLoop.ExecDoWhileLoop();
            //whileLoop.ExecWhileLoop();
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileDoLoops
{
    internal class WhileLoop
    {
        public void ExecWhileLoop()
        {
            int i = 0;
            while(i < 10)
            {
                Console.WriteLine("Printing i value is : " + i);
                i = i + 1;
            }
        }

        public void ExecDoWhileLoop()
        {
            int j = 0;
            do
            {
                Console.WriteLine("Printing j value is : " + j);
                j = j + 2;
            }
            while(j < 21);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetInterviewProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter the number");
            var inputNumber = Console.ReadLine();
            int.TryParse(inputNumber, out var value);
            if(value > 0)
            {
               var numList = inputNumber.ToCharArray();
                int result = 0;
                for(int i = 0; i < numList.Length; i++)
                {
                    result =  result + Convert.ToInt32(numList[i]);
                }
                Console.WriteLine("Result is : " + result);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Please enter number only");
                Console.ReadLine();
            }
        }
    }
}

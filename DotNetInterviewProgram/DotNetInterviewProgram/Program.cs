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
            Console.WriteLine("String Palindrome");
            var inpt = Console.ReadLine();

            Console.Write("Enter a Number To Check Palindrome : ");
            int number = int.Parse(Console.ReadLine());
            int remineder, sum = 0;
            int temp = number;
            while (number > 0)
            {
                //Get the remainder by dividing the number with 10  
                remineder = number % 10;
                //multiply the sum with 10 and then add the remainder
                sum = (sum * 10) + remineder;
                //Get the quotient by dividing the number with 10 
                number = number / 10;
            }
            if (temp == sum)
            {
                Console.WriteLine($"Number {temp} is Palindrome.");
            }
            else
            {
                Console.WriteLine($"Number {temp} is not Palindrome");
            }
            Console.ReadKey();

            Console.WriteLine("Please Enter the number");
            var inputNumber = Console.ReadLine();
            int.TryParse(inputNumber, out var value);
            if(value > 0)
            {
               var numList = inputNumber.ToCharArray();
                int result = 0;
                for(int i = numList.Length-1; i <= 0; i--)
                {
                    result =  result + Convert.ToInt32(numList[i].ToString());
                }
                Console.WriteLine("Result is : " + string.Join(" - ", numList) + " : " + result);
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

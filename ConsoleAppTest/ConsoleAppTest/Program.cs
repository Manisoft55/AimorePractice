using System;

namespace ConsoleAppTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please Enter Your Name....");
                var name = Console.ReadLine();
                Console.WriteLine("Hey " + name);
                Console.WriteLine("Welcome to ASP.Net Core Console Application....");
                Console.WriteLine("\n");

                Console.WriteLine("What operation do you want to perform, enter the number accordingly....");
                Console.WriteLine("1.Addition....");
                Console.WriteLine("2.Subtraction....");
                Console.WriteLine("3.Multiplication....");
                Console.WriteLine("4.Division....");

                var operationId = Convert.ToInt32(Console.ReadLine());
                if(operationId > 0 && operationId < 5)
                {
                    Console.WriteLine("Great Choice!!!");
                    Console.WriteLine("");

                    Console.WriteLine("Please enter the first number....");
                    int firstNumber = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter the second number....");
                    int secondNumber = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Final Answer : " + performOperation(operationId, firstNumber, secondNumber));
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Please enter the valid operation type!");
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        /// <summary>
        /// Method to perform operation
        /// </summary>
        /// <param name="operationId"></param>
        /// <param name="firstNum"></param>
        /// <param name="secondNum"></param>
        /// <returns>It returns the total value</returns>
        static int performOperation(int operationId, int firstNum, int secondNum)
        {
            int totalValue = 0;
            switch (operationId)
            {

                case 1:
                    totalValue = firstNum + secondNum;
                    break;

                case 2:
                    totalValue = firstNum - secondNum;
                    break;

                case 3:
                    totalValue = firstNum * secondNum;
                    break;

                case 4:
                    totalValue = firstNum / secondNum;
                    break;

                //default:
                //    Console.WriteLine("Please enter the valid operation type!");
                //    break;
            }
            return totalValue;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindCharacterInWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter your string");
                string inputString = Console.ReadLine();
                Console.WriteLine("Please enter your character");
                char charVariable = Convert.ToChar(Console.ReadLine());
                FindCharacterExample example = new FindCharacterExample();
                int result = example.FindCharacterCount(inputString, charVariable);
                Console.WriteLine($"Given character ' {charVariable} ' repeated in the word \" {inputString} \" for {result} times");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }           
        }
    }
}

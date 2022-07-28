using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class Program
    {
        int number = 5;

        /// <summary>
        /// It's a main method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            try
            {
                #region Code-28072022

                Console.WriteLine("Please Enter your first name");
                string firstName = Console.ReadLine();
                Console.WriteLine("Please enter your last name");
                string lastName = Console.ReadLine();
                Day28072022 day = new Day28072022();
                string fullName = day.FormFullName(firstName, lastName);
                Console.WriteLine("Your Full Name : " + fullName);
                Console.WriteLine("Your Name length is : " + fullName.Length);

                Console.WriteLine($"Your Full Name : {fullName} using interpolation");
                Console.ReadLine();


                Console.WriteLine("Please enter your age");
                string ageString = Console.ReadLine();
                Day28072022 objAge = new Day28072022();

                string outputAge = objAge.FindMajorOrMinor(Convert.ToInt32(ageString));
                Console.WriteLine(outputAge);
                Console.ReadLine();



                Console.WriteLine("Please enter the string");
                string inputStr = Console.ReadLine();

                Day28072022 objCode = new Day28072022();

                int inputNum = objCode.ConvertToNumber(inputStr);
                int outputNum = inputNum + 10;
                Console.WriteLine("Output is : " + outputNum);
                Console.ReadLine();
                #endregion


                #region Code-27072022
                Console.WriteLine("Test Program");
                string getString = Console.ReadLine();
                Console.WriteLine(getString);
                Console.ReadLine();
                #endregion

                #region UpdateEmployee
                #endregion
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.ReadLine();
            }

            
        }
    }
}

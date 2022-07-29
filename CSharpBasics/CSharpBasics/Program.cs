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

                #region Code-29072022
                Console.WriteLine("please enter day:");
                string today= Console.ReadLine();
                Day28072022 obj7 = new Day28072022();
                string returnDay=  obj7.ReturnDay(Convert.ToInt32(today));
                Console.WriteLine(returnDay);
                Console.ReadLine();


                Console.WriteLine("Please enter your first string");
                string inputString5 = Console.ReadLine();
                Console.WriteLine("Please enter your second string");
                string inputString6 = Console.ReadLine();
                Day28072022 obj6 = new Day28072022();
                Console.WriteLine(obj6.FindMatch(inputString5, inputString6));
                Console.ReadLine();



                Console.WriteLine("Please enter your string");
                string inputString4 = Console.ReadLine();
                Day28072022 obj5 = new Day28072022();
                Console.WriteLine(obj5.GetSubString(inputString4));
                Console.ReadLine();


                Console.WriteLine("Please enter your name");
                string sampleName2 = Console.ReadLine();
                Console.WriteLine("Please enter the character to find the position");
                string sampleCharac2 = Console.ReadLine();
                Day28072022 obj4 = new Day28072022();
                int index = obj4.FindIndex(sampleName2, sampleCharac2[0]);
                Console.WriteLine("Your character is placed at the position : " + index);
                Console.ReadLine();

                Console.WriteLine("Please enter your string");
                string sampleString = Console.ReadLine();
                Day28072022 obj3 = new Day28072022();
                string outputString2 = obj3.ReplaceCharacter(sampleString);
                Console.WriteLine(outputString2);
                Console.ReadLine();


                Console.WriteLine("Please enter your name");
                string sampleName = Console.ReadLine();
                Day28072022 obj2 = new Day28072022();

                string outString = obj2.EscapeCharcter(sampleName);
                Console.WriteLine(outString);
                Console.ReadLine();
                #endregion



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

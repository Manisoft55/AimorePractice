using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class Day28072022
    {
        public int ConvertToNumber(string inputString)
        {
            try
            {
                int number = Convert.ToInt32(inputString);
                return number;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return 0;
            }            
        }

        public string FindMajorOrMinor(int age)
        {
            try
            {
                if(age > 18 && age < 60)
                {
                    return "You're a major";
                }
                else if(age > 60)
                {
                    return "You're senior citizon";
                }
                else
                {
                    return "You're a minor";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return "Something is wrong";
            }
        }

        public string FormFullName(string firstName, string lastName)
        {
            try
            {
                string fullName = firstName.ToUpper() + " " + lastName.ToUpper();
                return fullName;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return string.Empty;
            }
        }
    }
}

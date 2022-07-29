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
        public string EscapeCharcter(string name)
        {
            try
            {
                string outputString = name + " another string is added \" Newly string added \"";
                return outputString;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return string.Empty;
            }
        }

        public string ReplaceCharacter(string inputString)
        {
            try 
            {
                //string outputString = inputString.Replace('a', 'b');
                //string outputString = inputString.Replace("declare", "declaring");
                string outputString = inputString.Replace("10", "200");
                return outputString;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return string.Empty;
            }
        }

        public int FindIndex(string inputString, char findCharacter)
        {
            return inputString.IndexOf(findCharacter);
        }

       public string GetSubString(string inputString)
       {
            //string outputString = inputString.Substring(5, 4);
            string outputString = inputString.Remove(5, 4);
            return outputString;
        }

        public bool FindMatch(string inputString, string inputString1)
        {
            //if(inputString == inputString1)
            //    return true;
            //else
            //    return false;

            return inputString == inputString1;
        }

        public string ReturnDay(int day)
        {
            switch (day)
            {
                case 1:
                    return "Monday";
                case 2:
                    goto case 3;
                    return "Tuesday";
                case 3:
                    return "Wednesday";
                case 4:
                    return "Thursday";
                case 5:
                    return "Friday";
                case 6:
                    return "Saturday";
                case 7:
                    return "Sunday";
                default:
                    return "Please enter valid number";
            }
               
        }
    }
}

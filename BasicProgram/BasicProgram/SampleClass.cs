using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgram
{
    internal class SampleClass
    {
        // Private
        // Public
        // Protected
        // Internal
        public string TestVariable;

        private string SampleMethod()
        {
            return "PrivateMethod";
        }

        /// <summary>
        /// This method returns sample text
        /// </summary>
        /// <returns>string format</returns>
        public string SampleMethodPublic()
        {
            // Below line is adding two integer number
            int i = 10 + 10;
            return "SampleMethodPublic";
        }

        /// <summary>
        /// It returns addition of two number
        /// </summary>
        /// <param name="numberOne"></param>
        /// <param name="numberTwo"></param>
        /// <returns>Total Value</returns>
        public int Addition(int numberOne, int numberTwo)
        {
            return numberOne + numberTwo;
        }

        public string IfElseCommand(int num)
        {
            if (num == 0)
            {
                return "This number is zero";
            }
            else
            {
                return "This number is greater that Zero.";
            }              
        }

        public int ForLoop(int num)
        {
            int total = 0;
            for(int init = 0; init < num; init++)
            {
                total = total + init;
            }
            return total;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExample
{
    internal class ArrExercise
    {
        public string[] ReturnSampleArray()
        {
            string[] arrString = new string[3];
            arrString[0] = "Test Zero";
            arrString[1] = "Test One";
            arrString[2] = "Test two";
            return arrString;
        }

        public string[] ReturnSampleArrayOne()
        {
            string[] arrString = { "Test Zero", "Test One" };
            return arrString;
        }

        public int[] ReturnSampleArrayInteger()
        {
            int[] arrInt = { 1, 20, 13, 674, 5, 120, 456 };
            arrInt[4] = 50;
            return arrInt;
        }
    }
}

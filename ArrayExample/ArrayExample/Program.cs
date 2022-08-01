using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExample
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Printing Array");

            ArrExercise arrExerciseOne = new ArrExercise();
            string[] arrValueOne = arrExerciseOne.ReturnSampleArray();
            for (int i = 0; i < arrValueOne.Length; i++)
            {
                Console.WriteLine(arrValueOne[i]);
            }

            Console.WriteLine("Printing value using foreach");
            foreach (var arr in arrValueOne)
            {
                Console.WriteLine(arr);
            }


            Console.ReadLine();

            Console.WriteLine("Find Max Value");
            int numberOne = 10;
            int numberTwo = 20;
            int maxNumber = Math.Max(numberOne, numberTwo);
            Console.WriteLine("Max Number : " + maxNumber);

            int minNumber = Math.Min(numberOne, numberTwo);
            Console.WriteLine("Min Number : " + minNumber);
            Console.ReadLine();

            double absNumber = -10.34534343;
            Console.WriteLine(Math.Abs(absNumber));

            Console.ReadLine();
            Console.WriteLine("Printing Integer Array");
            ArrExercise obj = new ArrExercise();
            int[] arrObj = obj.ReturnSampleArrayInteger();
            foreach(int num in arrObj)
            {
                Console.WriteLine(num);
            }
            Console.ReadLine();

            Console.WriteLine("Min Value");
            Console.WriteLine(arrObj.Min());

            Console.WriteLine("Max Value");
            Console.WriteLine(arrObj.Max());

            Console.WriteLine("Sum Value");
            Console.WriteLine(arrObj.Sum());


            Console.WriteLine("Printing Array One");

            ArrExercise arrExercise = new ArrExercise();
            string[] arrValue = arrExercise.ReturnSampleArrayOne();
            for (int i = 0; i < arrValue.Length; i++)
            {
                Console.WriteLine(arrValue[i]);
            }

            Console.WriteLine("Printing value using foreach");
            foreach (var arr in arrValue)
            {
                Console.WriteLine(arr);
            }

            Console.ReadLine();

           
        }
    }
}

using System;

namespace BasicProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Basic Program");

                // Instance
                SampleClass objClass = new SampleClass();
                int totValue = objClass.ForLoop(5);
                Console.WriteLine(totValue);
                string outputOne = objClass.IfElseCommand(0);
                string outputTwo = objClass.IfElseCommand(10);

                SampleClass objClassOne = new SampleClass();

                int totalValue = objClass.Addition(10, 10);
                string output = objClass.SampleMethodPublic();

                int inp = 0;
                string j = Console.ReadLine();
                inp = Convert.ToInt32(j);

                j = Convert.ToString(inp);

                string test = "";
                int i = 5;
                char c = 'a';
                double d = 12.34444343434343;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}

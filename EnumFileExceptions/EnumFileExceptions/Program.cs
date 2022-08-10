using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumFileExceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("File Creation");
                FilesExample filesExample = new FilesExample();
                throw new Exception("Please enter the value greater than hundred");
                int i = 126;
                int j = 125;
                int k = i / j;
                string s = filesExample.WriteStringInFile(Console.ReadLine());
                Console.WriteLine(s);
                Console.ReadLine();

                Console.WriteLine("Enum");
                Console.WriteLine(Days.Monday);
                Console.WriteLine(EmployeeTypes.Manager);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                FilesExample filesExample = new FilesExample();
                filesExample.WriteExceptionInFile(ex);
            }
            
        }
    }
}

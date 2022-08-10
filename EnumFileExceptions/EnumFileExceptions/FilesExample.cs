using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumFileExceptions
{
    internal class FilesExample
    {
        internal string WriteStringInFile(string inputString)
        {
            string filePath = @"D:\Aimore\TestFile.txt";
            using (var file = File.Create(filePath))
            {

            }

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine(inputString);
            }

            string writtenString = File.ReadAllText(filePath);
            File.Exists(filePath);
            return "Returned from Method : " + writtenString;
        }

        internal void WriteExceptionInFile(Exception ex)
        {
            var date = DateTime.Now.ToString().Replace(':','-');
            string filePath = $"D:\\Aimore\\Exception_{date}.txt";
            using (var file = File.Create(filePath))
            {

            }

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine(ex.ToString());
            }
        }
    }
}

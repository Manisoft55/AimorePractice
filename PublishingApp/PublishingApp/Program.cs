using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublishingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var date = DateTime.Now.ToString().Replace(':', ' ');
            string filePath = $"D:\\Aimore\\PublishApp{date}.txt";
            using(var fileCreate = File.Create(filePath))
            {

            }

            using(StreamWriter streamWriter = new StreamWriter(filePath))
            {
                streamWriter.WriteLine("Running time : " + DateTime.Now.ToString());
            }
        }
    }
}

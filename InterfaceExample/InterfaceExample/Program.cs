using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Interface Example");
            Mobile mobile = new SamsungMobile();
            Console.WriteLine(mobile.MobileModel());
            Console.WriteLine(mobile.AndriodVersion());

            SamsungMobile mobileOne = new SamsungMobile();
            Console.WriteLine(mobileOne.MobileModel());
            Console.WriteLine(mobileOne.AndriodVersion());

            Mobile mimobile = new MiMobile();
            Console.WriteLine(mimobile.MobileModel());
            Console.WriteLine(mimobile.AndriodVersion());
            Console.ReadLine();
        }
    }
}

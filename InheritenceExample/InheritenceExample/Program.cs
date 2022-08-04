using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inheritence");
            IPhone phone = new IPhone();
            phone.MobileModel();
            phone.GetMobileOS();
            Console.ReadLine();


            SamsungMobile samsungMobile = new SamsungMobile();
            samsungMobile.MobileModel();
            Console.WriteLine("Samsung OS type is : ");
            samsungMobile.GetMobileOS();

            MiMobile miMobile = new MiMobile();
            miMobile.MobileModel();
            Console.WriteLine("Mi MobilePadType is : ");
            miMobile.GetMobilePadType();
            Console.ReadLine();

            SamsungMobileOSUpdate samsung = new SamsungMobileOSUpdate();
            samsung.MobileOSVersion();
            samsung.GetMobileOS();
        }
    }
}

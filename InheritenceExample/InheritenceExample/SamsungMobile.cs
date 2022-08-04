using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceExample
{
    // Derived class
    internal class SamsungMobile : SmartPhone, MobileInterface
    {
        internal void MobileModel()
        {
            Console.WriteLine("Samsung Mobile");
        }  
        
        void MobileInterface.MobileString()
        {
            Console.WriteLine("Samsung Mobile");
        }
    }
}

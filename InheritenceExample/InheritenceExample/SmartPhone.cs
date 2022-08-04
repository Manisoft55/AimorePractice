using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceExample
{
    //Base class
    internal class SmartPhone
    {
        internal virtual void GetMobileOS()
        {
            Console.WriteLine("Android");
        }

        internal virtual void GetMobilePadType()
        {
            Console.WriteLine("Touch pad");
        }
    }
}

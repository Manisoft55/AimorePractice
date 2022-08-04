using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceExample
{
    internal class IPhone : SmartPhone
    {
        internal void MobileModel()
        {
            Console.WriteLine("IPhone");
        }

        internal override void GetMobileOS()
        {
            Console.WriteLine("IOS");
        }

        internal override void GetMobilePadType()
        {
            base.GetMobilePadType();
        }
    }
}

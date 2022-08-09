using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    internal class SamsungMobile : Mobile
    {

        public string AndriodVersion()
        {
            return "Android 11.0";
        }

        public string MobileModel()
        {
            return "Samsung";
        }
    }
}

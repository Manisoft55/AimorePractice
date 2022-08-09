using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    internal class MiMobile : Mobile
    {
        public string AndriodVersion()
        {
            return "Android 10.0";
        }

        public string MobileModel()
        {
            return "Mi";
        }
    }
}

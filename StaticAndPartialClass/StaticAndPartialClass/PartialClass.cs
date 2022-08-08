using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticAndPartialClass
{
    internal partial class PartialClass
    {
        internal void ReturnPartialString()
        {
            Console.WriteLine("Partial string");
        }
    }

    internal partial class PartialClass
    {
        internal void ReturnPartialStringFromFirstInstance()
        {
            Console.WriteLine("Partial string FirstInstance");
        }
    }

    internal partial class PartialClass
    {
        internal void ReturnPartialStringFromSecondInstance()
        {
            Console.WriteLine("Partial string SecondInstance");
        }
    }

    internal class PartialClassOne : PartialClass
    {
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExe
{
    internal abstract class AbsClass
    {
        public abstract string Name { get; }
        public abstract string ReturnNameValue();
    }

    internal class BaseClass : AbsClass
    {
        public BaseClass()
        {
            Console.WriteLine("Base Class");
        }

        public override string Name => throw new NotImplementedException();

        public override string ReturnNameValue()
        {
            throw new NotImplementedException();
        }
    }

    internal partial class BaseClassOne
    {
        public int MyProperty { get; set; }
    }
    internal partial class BaseClassOne
    {
        public int MyPropertyOne { get; set; }
    }

    internal partial class BaseClassOne
    {
        public int MyPropertyTwo { get; set; }
    }

    internal partial class BaseClassOne
    {
        public int MyPropertyThree { get; set; }
    }
}

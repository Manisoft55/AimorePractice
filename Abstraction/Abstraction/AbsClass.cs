using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal abstract class AbsClass
    {
        internal abstract int AddMyValueWithHundred(int numberOne);
    }

    internal class AdditionClass : AbsClass
    {
        private int number = 100;

        internal override int AddMyValueWithHundred(int numberOne)
        {
            return number + numberOne;
        }
    }
}

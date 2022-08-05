using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseClass cls = new BaseClass();
            cls.ReturnNameValue();
            SealClass sealClass = new SealClass();
            sealClass.Stringgg();
            StatClass.CallMethodForString("");
            var st = new StatClass();
            st.CallMethod();

            BaseClassOne baseClassOne = new BaseClassOne();
            baseClassOne.MyPropertyThree = 5;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticAndPartialClass
{
    internal static class StaticClassExample
    {
        internal static float PiValue = 3.141f;
        internal static string AdditionLabel = "Addition";

        internal static float AddNumberWithPiValue(float number)
        {
            return PiValue + number;
        }

        internal static string ReturnString()
        {
            return string.Empty;
        }

        internal static string ConvertToString(this int val)
        {
            return Convert.ToString(val);
        }
    }

    internal class StaticClass
    {
        internal static string ReturnStaticMethod()
        {
            return "Static Method";
        }

        internal string NormalMethod()
        {
            return "Normal Method";
        }
    }

    }

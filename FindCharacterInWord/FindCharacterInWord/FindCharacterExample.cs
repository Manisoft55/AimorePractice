using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindCharacterInWord
{
    internal class FindCharacterExample
    {
        internal int FindCharacterCount(string inputString, char inputChar)
        {
            int repCount = 0;
            char[] charArr = inputString.ToCharArray();
            foreach(var charElement in charArr)
            {
                if(charElement == inputChar)
                    repCount++;
            }
            return repCount;
        }
    }
}

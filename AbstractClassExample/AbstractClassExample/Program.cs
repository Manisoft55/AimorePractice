using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sealed Class");
            SealedCls sealedCls = new SealedCls();
            Console.WriteLine(sealedCls.CurrencyValue());
            Console.ReadLine();

            Console.WriteLine("RBI Rule");
            PunjabBank punjabBank = new PunjabBank();
            punjabBank.NetBanking();
            Console.WriteLine(punjabBank.HomeLoadInterestRate());
            Console.ReadLine();
        }
    }
}

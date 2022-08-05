using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassExample
{
    internal abstract class ReserveBankAbstract
    {
        internal abstract void NetBanking();
        internal float HomeLoadInterestRate()
        {
            return 8.50f;
        }
    }

    internal class PunjabBank : ReserveBankAbstract
    {
        internal override void NetBanking()
        {
            Console.WriteLine("NetBanking provided");
        }
    }

    internal class StateBank : ReserveBankAbstract
    {
        internal override void NetBanking()
        {
            Console.WriteLine("NetBanking provided");
        }
    }

    // Sealed class
    internal sealed class SealedCls
    {
        internal float CurrencyValue()
        {
            return 80.10f;
        }
    }


}

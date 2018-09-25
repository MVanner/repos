using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusApp
{
    public delegate double DG_BonusProvider(double amount);

    public class Bonuses
    {
       
        public double TenProcent(double amount)
        {
            return amount / 10;
        }

        public double FlatTwoIfAmountMoreThanFive(double amount)
        {
            double retur;
            if (amount > 5)
            {
                retur = 2.0;
            }
            else
            {
                retur = 0.0;
            }
            return retur;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    internal class SilverAccount : AccountBase
    {
        public override int CalculateRewardPoints(decimal amount)
        {
            return (int)decimal.Floor(amount / SilverTransactionCostPerPoint);
        }

        private const int SilverTransactionCostPerPoint = 10;
    }
}

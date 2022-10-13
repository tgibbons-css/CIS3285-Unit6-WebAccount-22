using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    internal class GoldAccount : AccountBase
    {
        public override int CalculateRewardPoints(decimal amount)
        {
            return (int)decimal.Floor((Balance / GoldBalanceCostPerPoint) + (amount / GoldTransactionCostPerPoint));
        }

        private const int GoldTransactionCostPerPoint = 5;
        private const int GoldBalanceCostPerPoint = 2000;
    }
}

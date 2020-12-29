using System;
namespace ArtistPayments.Shared
{
    public class ConfigSelections
    {
        public Decimal payPerStream = 0.004M;
        public Decimal _monthlySubscriptionCost = 9.99M;
        public string monthlySubscriptionCost
        {
            get
            {
                return _monthlySubscriptionCost.ToString();
            }
            set
            {
                _monthlySubscriptionCost = Decimal.Parse(value);
            }
        }
    }
}

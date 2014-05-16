using System.Collections.Generic;
using OpenDDD;

namespace UnleashedDDD.Accounting.Domain.Model.CurrencyRates
{
    public class CurrencyRates : Aggregate
    {
        private readonly List<CurrencyRate> _rates = new List<CurrencyRate>();

        public IEnumerable<CurrencyRate> Rates { get { return _rates; } }
    }
}
using System.Collections.Generic;
using System.Linq;
using OpenDDD;

namespace UnleashedDDD.Sales.Domain.Model.SellPriceTiers
{
    public class SellPriceTiers : Aggregate
    {
        private readonly List<SellPriceTier> _tiers = new List<SellPriceTier>();

        public IEnumerable<SellPriceTier> Tiers { get { return _tiers; } }

        public SellPriceTier this[int i]
        {
            get { return Tiers.FirstOrDefault(p => p.Number == new SellPriceTierNumber(i)); }
        }

        public SellPriceTiers()
        {
            for (var i = 1; i < 11; i++)
                _tiers.Add(
                    new SellPriceTier(
                        new SellPriceTierNumber(i)));
        }
    }
}
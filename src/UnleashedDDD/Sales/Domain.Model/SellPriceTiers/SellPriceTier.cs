using OpenDDD;

namespace UnleashedDDD.Sales.Domain.Model.SellPriceTiers
{
    public class SellPriceTier : Entity
    {
        public SellPriceTierNumber Number { get; private set; }

        public SellPriceTierName Name { get; private set; }

        public SellPriceTier(SellPriceTierNumber number)
        {
            Number = number;
        }

        public void Rename(SellPriceTierName name)
        {
            Name = name;
        }

    }
}
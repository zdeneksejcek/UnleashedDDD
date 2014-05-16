using System;
using OpenDDD.Common;

namespace UnleashedDDD.Sales.Domain.Model.SellPriceTiers
{
    public class SellPriceTierNumber : GenericValueObject<int>
    {
        public int Number { get { return Value;  }}

        public SellPriceTierNumber(int number) : base(number)
        {
            if (number < 1 || number > 10)
                throw new Exception();
        }
    }
}

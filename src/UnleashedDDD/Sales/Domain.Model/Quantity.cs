using OpenDDD;
using OpenDDD.Common;

namespace UnleashedDDD.Sales.Domain.Model
{
    public class Quantity : GenericValueObject<decimal>
    {
        public new decimal Value { get { return base.Value; } }

        public Quantity(decimal value) : base(value)
        {
            AssertionConcern.AssertArgumentRange(value, 1, int.MaxValue, "Product quantity must be positive");
        }

        static public implicit operator Quantity(decimal value)
        {
            return new Quantity(value);
        }

        static public implicit operator decimal(Quantity quantity)
        {
            return quantity.Value;
        }
    }
}
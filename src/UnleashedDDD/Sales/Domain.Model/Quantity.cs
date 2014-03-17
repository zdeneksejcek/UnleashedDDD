using OpenDDD;
using OpenDDD.Common;

namespace UnleashedDDD.Sales.Domain.Model
{
    public class Quantity : GenericValueObject<int>
    {
        public new int Value { get { return base.Value; } }

        public Quantity(int value) : base(value)
        {
            AssertionConcern.AssertArgumentRange(value, 1, int.MaxValue, "Product quantity must be positive");
        }

        static public implicit operator Quantity(int value)
        {
            return new Quantity(value);
        }

        static public implicit operator int(Quantity quantity)
        {
            return quantity.Value;
        }
    }
}
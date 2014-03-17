using OpenDDD.Common;

namespace UnleashedDDD.Sales.Domain.Model.SalesOrder
{
    public class Comment : GenericValueObject<string>
    {
        public Comment(string value) : base(value) { }
    }
}
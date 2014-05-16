using System.Collections.Generic;
using OpenDDD;

namespace UnleashedDDD.Sales.Domain.Model.CustomerTypes
{
    public class CustomerTypes : Aggregate
    {
        public readonly List<CustomerType> _types = new List<CustomerType>();
    }
}
using OpenDDD;

namespace UnleashedDDD.Sales.Domain.Model.ShippingCompanies
{
    public class ShippingCompany : Entity
    {
        public string Name { get; private set; }

        public ShippingCompany(string name)
        {
            Name = name;
        }

        public void Rename(string name)
        {
            Name = name;
        }
    }
}

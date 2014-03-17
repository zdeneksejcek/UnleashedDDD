using OpenDDD;
using UnleashedDDD.Accounting;
using UnleashedDDD.Inventory;
using UnleashedDDD.Organizations;
using UnleashedDDD.Sales;

namespace UnleashedDDD
{
    public class UnleashedCore
    {
        public OrganizationsFacade Organizations { get; private set; }

        public InventoryFacade Inventory { get; private set; }

        public SalesFacade Sales { get; private set; }

        public AccountingFacade Accounting { get; private set; }

        public UnleashedCore(Core core)
        {
            Organizations = new OrganizationsFacade(core);
            Inventory = new InventoryFacade(core);
            Sales = new SalesFacade(core);
            Accounting = new AccountingFacade(core);
        }
    }
}
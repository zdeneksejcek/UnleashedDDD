using UnleashedDDD.Sales.Application.Commands;
using UnleashedDDD.Sales.Application.Model;

namespace UnleashedDDD.Sales
{
    public class SalesFacade
    {
        private OpenDDD.Core Core { get; set; }

        public SalesFacade(OpenDDD.Core core)
        {
            Core = core;
        }

        public NewSalesOrderModel CreateNewSalesOrder(NewSalesOrderCommand command)
        {
            return Core.ExecuteWithResult<NewSalesOrderCommand, NewSalesOrderModel>(command);
        }

    }
}
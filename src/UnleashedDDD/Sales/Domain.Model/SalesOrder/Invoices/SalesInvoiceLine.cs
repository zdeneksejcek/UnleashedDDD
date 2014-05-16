using OpenDDD;

namespace UnleashedDDD.Sales.Domain.Model.SalesOrder.Invoices
{
    public class SalesInvoiceLine : Entity
    {
        public Quantity LineQuantity { get; private set; }

        public LineId Line { get; private set; }

        public SalesInvoiceLine(Quantity quantity)
        {
            Line = new LineId();

            LineQuantity = quantity;
        }

    }
}
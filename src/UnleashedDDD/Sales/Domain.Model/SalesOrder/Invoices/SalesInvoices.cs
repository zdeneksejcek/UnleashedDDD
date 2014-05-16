using System.Collections.Generic;

namespace UnleashedDDD.Sales.Domain.Model.SalesOrder.Invoices
{
    public class SalesInvoices
    {
        private readonly List<SalesInvoice> _invoices = new List<SalesInvoice>();
        public IEnumerable<SalesInvoice> Invoices { get { return _invoices; } }

        private SalesOrder Order { get; set; }

        public SalesInvoices(SalesOrder parentOrder)
        {
            Order = parentOrder;
        }

        public void CreateInvoice()
        {
            //var invoice = new SalesInvoice();

            //_invoices.Add();
        }

    }
}
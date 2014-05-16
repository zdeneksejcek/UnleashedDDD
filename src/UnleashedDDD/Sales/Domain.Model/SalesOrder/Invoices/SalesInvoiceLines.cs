using System.Collections.Generic;

namespace UnleashedDDD.Sales.Domain.Model.SalesOrder.Invoices
{
    public class SalesInvoiceLines
    {
        private readonly List<SalesInvoiceLine> _lines = new List<SalesInvoiceLine>();

        public IEnumerable<SalesInvoiceLine> Lines { get { return _lines; } }
    }
}
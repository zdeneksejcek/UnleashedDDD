using System.Collections.Generic;
using System.Linq;
using OpenDDD.Common;
using UnleashedDDD.Sales.Domain.Model.SalesOrder.Exceptions;

namespace UnleashedDDD.Sales.Domain.Model.SalesOrder
{
    public class Lines : IEnumerable<Line>
    {
        private readonly List<Line> _lines = new List<Line>();

        private SalesOrderId SalesOrder { get; set; }

        private readonly Status OrderStatus;

        internal Lines(SalesOrderId salesOrder, ref Status orderStatus)
        {
            SalesOrder = salesOrder;
            OrderStatus = orderStatus;
        }

        public Line Get(LineId lineId)
        {
            var line = _lines.FirstOrDefault(p => p.Id.Id == lineId.Id);
            if (line == null)
                throw new LineDoesNotExist();

            return line;
        }

        public Line Add(ProductId product, Quantity quantity, UnitPrice price, SalesTax tax)
        {
            AssureSameLineCurrency(price.Currency);
            OrderStatus.AssureChangeToOrderIsAllowed();

            var line = new Line(SalesOrder, product, quantity, price, tax);
            _lines.Add(line);

            return line;
        }

        private void AssureSameLineCurrency(Currency currency)
        {
            if (GetSalesOrderCurrency() == Currency.Unknown)
                return;

            if (GetSalesOrderCurrency() != currency)
                throw new MultipleCurrenciesNotSupported(SalesOrder, currency);
        }

        public void AssureAllLinesAllocated()
        {
            var containsUnallocatedLine = _lines.Any(p => p.Status != LineStatus.Allocated);

            if (containsUnallocatedLine)
                throw new OrderContainsUnallocatedLines();
        }

        public void AssureContainsAnyLines()
        {
            if (!_lines.Any())
                throw new NoLine();
        }

        internal Currency GetSalesOrderCurrency()
        {
            var firstLine = _lines.FirstOrDefault();

            return firstLine != null ? firstLine.Price.Currency : Currency.Unknown;
        }

        internal void Remove(Line line)
        {
            OrderStatus.AssureChangeToOrderIsAllowed();

            _lines.Remove(line);
        }

        public IEnumerator<Line> GetEnumerator()
        {
            return _lines.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
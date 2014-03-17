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

        internal Lines(SalesOrderId salesOrder)
        {
            SalesOrder = salesOrder;
        }

        public Line GetLine(LineId lineId)
        {
            var line = _lines.FirstOrDefault(p => p.Id == lineId);
            if (line == null)
                throw new LineDoesNotExist();

            return line;
        }

        internal Line AddLine(ProductId product, Quantity quantity, UnitPrice price, SalesTax tax)
        {
            AssureSameLineCurrency(price.Currency);

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

        internal Currency GetSalesOrderCurrency()
        {
            var firstLine = _lines.FirstOrDefault();

            return firstLine != null ? firstLine.Price.Currency : Currency.Unknown;
        }

        internal void RemoveLine(Line line)
        {
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
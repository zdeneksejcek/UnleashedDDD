namespace UnleashedDDD.Sales.Domain.Model.SalesOrder
{
    public class SalesOrderBuilder
    {
        public static SalesOrder Build(Memento memento)
        {
            return new SalesOrder(memento);
        }
    }
}
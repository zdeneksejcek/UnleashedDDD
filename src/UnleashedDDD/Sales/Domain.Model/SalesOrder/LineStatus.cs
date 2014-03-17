namespace UnleashedDDD.Sales.Domain.Model.SalesOrder
{
    public enum LineStatus
    {
        Open,
        Allocating,
        Allocated,
        AllocationFailed
    }
}
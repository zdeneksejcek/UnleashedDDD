namespace UnleashedDDD.Infrastructure.InMemory.Multitenent
{
    public interface IOrganizationContextFactory
    {
        OrganizationContext GetContext();
    }
}

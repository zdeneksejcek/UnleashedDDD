namespace UnleashedDDD.Infrastructure.Azure
{
    public interface IOrganizationContextFactory
    {
        OrganizationContext GetContext();
    }
}
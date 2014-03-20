using System;
using UnleashedDDD.Infrastructure.InMemory.Multitenent;

namespace UnleashedDDD.Main
{
    public class OrganizationContextFactory : IOrganizationContextFactory
    {
        public OrganizationContext GetContext()
        {
            return new OrganizationContext(Guid.NewGuid());
        }
    }
}
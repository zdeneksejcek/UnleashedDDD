using System;

namespace UnleashedDDD.Infrastructure.InMemory.Multitenent
{
    public class OrganizationContext
    {
        public Guid OrganizationId { get; private set; }

        public OrganizationContext(Guid id)
        {
            OrganizationId = id;
        }
    }
}

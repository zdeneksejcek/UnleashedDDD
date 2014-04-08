using System;

namespace UnleashedDDD.Infrastructure.Azure
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
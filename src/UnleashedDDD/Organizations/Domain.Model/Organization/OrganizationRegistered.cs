using System;
using OpenDDD;

namespace UnleashedDDD.Organizations.Domain.Model.Organization
{
    public class OrganizationRegistered : Event
    {
        public Guid OrganizationId { get; private set; }

        public OrganizationRegistered(Guid organizationId)
        {
            OrganizationId = organizationId;
        }
    }
}
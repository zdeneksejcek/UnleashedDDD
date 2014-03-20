using System;
using UnleashedDDD.Organizations.Domain.Model.Organization;
using UnleashedDDD.Organizations.Port;

namespace UnleashedDDD.Tests.Stubs
{
    public class OrganizationRepository : IOrganizationRepository
    {
        public Organization ShouldBe { get; set; }

        public Organization GetById(OrganizationId id)
        {
            return ShouldBe;
        }

        public void Save(Organization organization)
        {
            ShouldBe = organization;
        }
    }
}

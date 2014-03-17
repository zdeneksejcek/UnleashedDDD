using System.Collections.Generic;
using System.Linq;
using UnleashedDDD.Organizations.Domain.Model.Organization;
using UnleashedDDD.Organizations.Port;

namespace UnleashedDDD.Infrastructure.InMemory.Organizations
{
    public class OrganizationRepository : IOrganizationRepository
    {
        private List<Organization> _list = new List<Organization>();  

        public Organization GetById(OrganizationId id)
        {
            return _list.FirstOrDefault(p => p.Id.Id == id.Id);
        }

        public void Save(Organization organization)
        {
            _list.Add(organization);
        }
    }
}

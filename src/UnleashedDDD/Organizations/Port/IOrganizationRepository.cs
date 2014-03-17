using OpenDDD;
using UnleashedDDD.Organizations.Domain.Model.Organization;

namespace UnleashedDDD.Organizations.Port
{
    public interface IOrganizationRepository : IExternalImplementationRequired
    {
        Organization GetById(OrganizationId id);

        void Save(Organization organization);
    }
}
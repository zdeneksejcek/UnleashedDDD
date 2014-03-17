using System.Collections.Generic;
using OpenDDD;
using UnleashedDDD.Organizations.Domain.Model.Organization;
using UnleashedDDD.Organizations.Port.Model;

namespace UnleashedDDD.Organizations.Port
{
    public interface IUserByOrganizationQueryRetriever : IExternalImplementationRequired
    {
        IEnumerable<UserQueryResult> GetByOrganization(OrganizationId organization);
    }
}
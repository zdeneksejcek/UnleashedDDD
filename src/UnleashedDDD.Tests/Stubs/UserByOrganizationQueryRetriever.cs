using System;
using System.Collections.Generic;
using UnleashedDDD.Organizations.Domain.Model.Organization;
using UnleashedDDD.Organizations.Port;
using UnleashedDDD.Organizations.Port.Model;

namespace UnleashedDDD.Tests.Stubs
{
    public class UserByOrganizationQueryRetriever : IUserByOrganizationQueryRetriever
    {
        public IEnumerable<UserQueryResult> GetByOrganization(OrganizationId organization)
        {
            throw new NotImplementedException();
        }
    }
}

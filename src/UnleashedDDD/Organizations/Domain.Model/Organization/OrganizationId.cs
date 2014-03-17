using System;
using OpenDDD.Common;

namespace UnleashedDDD.Organizations.Domain.Model.Organization
{
    public class OrganizationId : IdValueObject
    {
        public OrganizationId(Guid id) : base(id) { }
    }
}
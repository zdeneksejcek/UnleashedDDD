using System;
using OpenDDD.Common;

namespace UnleashedDDD.Accounting.Domain.Model
{
    public class OrganizationId : IdValueObject
    {
        public OrganizationId(Guid id) : base(id) { }
    }
}
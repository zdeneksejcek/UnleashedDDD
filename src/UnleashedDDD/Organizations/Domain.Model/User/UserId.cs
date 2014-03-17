using System;
using System.Diagnostics;
using OpenDDD.Common;

namespace UnleashedDDD.Organizations.Domain.Model.User
{
    [DebuggerDisplay("{Id}")]
    public class UserId : IdValueObject
    {
        public UserId(Guid id) : base(id) { }
    }
}
using System;

namespace UnleashedDDD.Organizations.Port.Model
{
    public class UserQueryResult
    {
        public Guid Id { get; private set; }
        public string Email { get; private set; }
        public UserQueryResult(Guid id, string email)
        {
            Id = id;
            Email = email;
        }
    }
}

using System;
using System.Diagnostics;
using OpenDDD;

namespace UnleashedDDD.Organizations.Domain.Model.User
{
    [DebuggerDisplay("{Email} {Id}")]
    public class User : Aggregate
    {
        public UserId Id { get; private set; }
        public UserEmail Email { get; private set; }

        public User(UserEmail email)
        {
            Id = new UserId(Guid.NewGuid());
            Email = email;
        }

        #region restore

        private User(Guid id, string email)
        {
            Id = new UserId(id);
            Email = new UserEmail(email);
        }

        public static User Restore(Guid id, string email)
        {
            return new User(id, email);
        }

        #endregion


    }
}
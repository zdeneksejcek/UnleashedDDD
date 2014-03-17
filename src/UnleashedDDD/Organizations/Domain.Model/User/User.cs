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

        private User(UserId id)
        {
            
        }

        public static User Restore(UserId id)
        {
            return new User(id);
        }

        #endregion


    }
}
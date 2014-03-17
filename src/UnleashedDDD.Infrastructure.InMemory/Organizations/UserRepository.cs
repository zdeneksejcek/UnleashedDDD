using System;
using System.Collections.Generic;
using System.Linq;
using UnleashedDDD.Organizations.Domain.Model.Organization;
using UnleashedDDD.Organizations.Domain.Model.User;
using UnleashedDDD.Organizations.Port;
using UnleashedDDD.Organizations.Port.Model;

namespace UnleashedDDD.Infrastructure.InMemory.Organizations
{
    public class UserRepository : IUserRepository, IUserByOrganizationQueryRetriever, IUserByEmailQueryRetriever
    {
        private List<User> _list = new List<User>();

        public User GetById(UserId id)
        {
            return _list.FirstOrDefault(p => p.Id.Id == id.Id);
        }

        public void Save(User user)
        {
            _list.Add(user);
        }

        public IEnumerable<UserQueryResult> GetByOrganization(OrganizationId organization)
        {
            throw new NotImplementedException();
        }

        public UserQueryResult GetByEmail(string email)
        {
            var user = _list.FirstOrDefault(p => p.Email.EmailAddress == email);

            if (user == null)
                return null;

            return new UserQueryResult(user.Id.Id, user.Email.EmailAddress);
        }
    }
}

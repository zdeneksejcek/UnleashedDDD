using System.Collections.Generic;
using UnleashedDDD.Organizations.Domain.Model.Organization;
using UnleashedDDD.Organizations.Domain.Model.User;
using UnleashedDDD.Organizations.Port;
using UnleashedDDD.Organizations.Port.Model;

namespace UnleashedDDD.Infrastructure.Azure.Organizations
{
    public class UserRepository : BaseTableRepository<UserTableEntity>, IUserRepository, IUserByOrganizationQueryRetriever, IUserByEmailQueryRetriever
    {
        public UserRepository(IAzureConfiguration configuration) : base(configuration, "SalesOrders") { }

        public User GetById(UserId id)
        {
            var entity = GetEntity(id.Id);

            if (entity == null)
                return null;

            return User.Restore(entity.Id, entity.Email);
        }

        public void Save(User user)
        {
            var entity = new UserTableEntity(user.Id.Id, user.Email.EmailAddress);

            base.Save(entity);
        }

        public IEnumerable<UserQueryResult> GetByOrganization(OrganizationId organization)
        {
            return new List<UserQueryResult>();
        }

        public UserQueryResult GetByEmail(string email)
        {
            return null;
        }
    }
}

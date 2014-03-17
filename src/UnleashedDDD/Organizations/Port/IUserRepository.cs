using OpenDDD;
using UnleashedDDD.Organizations.Domain.Model.User;

namespace UnleashedDDD.Organizations.Port
{
    public interface IUserRepository : IExternalImplementationRequired
    {
        User GetById(UserId id);

        void Save(User user);
    }
}
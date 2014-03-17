using OpenDDD;
using UnleashedDDD.Organizations.Port.Model;

namespace UnleashedDDD.Organizations.Port
{
    public interface IUserByEmailQueryRetriever : IExternalImplementationRequired
    {
        UserQueryResult GetByEmail(string email);
    }
}
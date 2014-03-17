using UnleashedDDD.Organizations.Port;
using UnleashedDDD.Organizations.Port.Model;

namespace UnleashedDDD.Tests.Stubs
{
    public class UserByEmailQueryRetrieverStub : IUserByEmailQueryRetriever
    {
        public UserQueryResult GetByEmail(string email)
        {
            return null;
        }
    }
}

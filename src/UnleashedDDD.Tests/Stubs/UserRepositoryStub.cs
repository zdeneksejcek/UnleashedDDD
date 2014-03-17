using UnleashedDDD.Organizations.Domain.Model.User;
using UnleashedDDD.Organizations.Port;

namespace UnleashedDDD.Tests.Stubs
{
    public class UserRepositoryStub : IUserRepository
    {
        public User ShouldBe { get; set; }
        public bool SaveMethodCalled { get; private set; }

        public User SavedUser { get; private set; }

        public User GetById(UserId id)
        {
            return ShouldBe;
        }

        public void Save(User user)
        {
            SaveMethodCalled = true;
            SavedUser = user;
        }
    }
}
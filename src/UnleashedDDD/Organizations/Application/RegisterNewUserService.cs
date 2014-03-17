using OpenDDD;
using UnleashedDDD.Organizations.Application.Commands;
using UnleashedDDD.Organizations.Application.Exceptions;
using UnleashedDDD.Organizations.Domain.Model.User;
using UnleashedDDD.Organizations.Port;

namespace UnleashedDDD.Organizations.Application
{
    public class RegisterNewUserService : IApplicationService
    {
        private readonly IUserRepository _repository;
        private readonly IUserByEmailQueryRetriever _byEmailQueryRetriever;

        public RegisterNewUserService(IUserRepository repository, IUserByEmailQueryRetriever userQueryRetriever)
        {
            _repository = repository;
            _byEmailQueryRetriever = userQueryRetriever;
        }

        public void Register(NewUserCommand command)
        {
            var existingUser = _byEmailQueryRetriever.GetByEmail(command.Email);

            if (existingUser != null)
                throw new UserWithEmailIsAlreadyRegistered();

            using (var uow = new UnitOfWork())
            {
                var newUser = new User(new UserEmail(command.Email));

                _repository.Save(newUser);

                uow.Commit();
            }
        }
    }
}
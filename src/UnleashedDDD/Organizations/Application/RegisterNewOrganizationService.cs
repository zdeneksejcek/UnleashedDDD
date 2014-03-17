using OpenDDD;
using OpenDDD.Attributes;
using UnleashedDDD.Organizations.Application.Commands;
using UnleashedDDD.Organizations.Application.Results;
using UnleashedDDD.Organizations.Domain.Model.Organization;
using UnleashedDDD.Organizations.Domain.Model.User;
using UnleashedDDD.Organizations.Port;

namespace UnleashedDDD.Organizations.Application
{
    internal class RegisterNewOrganizationService : IApplicationService
    {
        private readonly IOrganizationRepository _repository;

        public RegisterNewOrganizationService(IOrganizationRepository repository)
        {
            _repository = repository;
        }

        [UnitOfWork]
        public NewOrganizationResult Register(NewOrganizationCommand command)
        {
            var organization = new Organization(
                new OrganizationName(command.OrganizationName),
                new UserId(command.OwnerId));

            _repository.Save(organization);

            return new NewOrganizationResult(organization);
        }

    }
}
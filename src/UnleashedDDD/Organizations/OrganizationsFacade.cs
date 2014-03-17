using UnleashedDDD.Organizations.Application.Commands;
using UnleashedDDD.Organizations.Application.Results;

namespace UnleashedDDD.Organizations
{
    public class OrganizationsFacade
    {
        private OpenDDD.Core Core { get; set; }

        public OrganizationsFacade(OpenDDD.Core core)
        {
            Core = core;
        }

        public void RegisterNewUser(NewUserCommand command)
        {
            Core.Execute(command);
        }

        public NewOrganizationResult RegisterNewOrganization(NewOrganizationCommand command)
        {
            return Core.ExecuteWithResult<NewOrganizationCommand, NewOrganizationResult>(command);
        }
    }
}
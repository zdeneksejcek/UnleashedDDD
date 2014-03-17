using UnleashedDDD.Organizations.Domain.Model.Organization;

namespace UnleashedDDD.Organizations.Application.Results
{
    public class NewOrganizationResult
    {
        public string Name { get; private set; }

        public NewOrganizationResult(Organization organization)
        {
            Name = organization.Name.Name;
        }
    }
}

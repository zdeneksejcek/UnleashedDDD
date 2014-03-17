using OpenDDD.Common;

namespace UnleashedDDD.Organizations.Domain.Model.Organization
{
    public class OrganizationName : GenericValueObject<string>
    {
        public string Name { get { return Value; } }

        public OrganizationName(string value) : base(value)
        {

        }
    }
}

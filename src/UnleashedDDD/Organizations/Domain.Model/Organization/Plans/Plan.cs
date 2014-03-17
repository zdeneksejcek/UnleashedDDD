using OpenDDD;

namespace UnleashedDDD.Organizations.Domain.Model.Organization.Plans
{
    public abstract class Plan : IValueObject
    {
        public abstract string Name { get; }
    }
}
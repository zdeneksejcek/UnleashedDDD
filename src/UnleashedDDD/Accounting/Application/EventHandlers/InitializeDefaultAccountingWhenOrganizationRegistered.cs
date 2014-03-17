using OpenDDD;
using UnleashedDDD.Organizations.Domain.Model.Organization;

namespace UnleashedDDD.Accounting.Application.EventHandlers
{
    public class InitializeDefaultAccountingWhenOrganizationRegistered : IEventualEventHandler<OrganizationRegistered>
    {
        public void Handle(OrganizationRegistered @event)
        {
            throw new System.NotImplementedException();
        }
    }
}
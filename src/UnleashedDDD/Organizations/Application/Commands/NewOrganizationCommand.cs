
using System;
using OpenDDD;

namespace UnleashedDDD.Organizations.Application.Commands
{
    public class NewOrganizationCommand : Command
    {
        public Guid OwnerId { get; private set; }
        public string OrganizationName { get; private set; }

        public NewOrganizationCommand(Guid ownerId, string organizationName)
        {
            OwnerId = ownerId;
            OrganizationName = organizationName;
        }

    }
}
using System;
using OpenDDD;
using UnleashedDDD.Organizations.Domain.Model.Organization.Plans;
using UnleashedDDD.Organizations.Domain.Model.User;

namespace UnleashedDDD.Organizations.Domain.Model.Organization
{
    public class Organization : Aggregate
    {
        public OrganizationId Id { get; private set; }

        public OrganizationName Name { get; private set; }

        public UserId Owner { get; private set; }

        public OrganizationState State { get; private set; }

        public Plan Plan { get; private set; }

        public Organization(OrganizationName name, UserId owner)
        {
            Id = new OrganizationId(Guid.NewGuid());
            Name = name;
            Owner = owner;

            State = OrganizationState.Initializating;

            EventDispacher.Raise(new OrganizationRegistered(Id.Id));
        }
    }
}
using System;

namespace UnleashedDDD.Accounting.Application.Model
{
    public class ConfigurationModel
    {
        public Guid OrganizationId { get; private set; }

        public ConfigurationModel(Guid organizatinId)
        {
            OrganizationId = organizatinId;
        }
    }
}
using System;
using Microsoft.WindowsAzure.Storage.Table;

namespace UnleashedDDD.Infrastructure.Azure.Organizations
{
    public class UserTableEntity : TableEntity
    {
        public string Email { get; set; }
        public Guid Id { get; set; }

        public UserTableEntity(Guid id, string email)
        {
            this.PartitionKey = id.ToString();
            this.RowKey = email;

            Email = email;
            Id = id;
        }
    }
}

using System;
using Microsoft.WindowsAzure.Storage.Table;

namespace UnleashedDDD.Infrastructure.Azure
{
    public class SerializedEntity : TableEntity
    {
        Guid Id { get; set; }

        byte[] Data { get; set; }

        public SerializedEntity(string partition, string row, Guid id, byte[] data)
        {
            PartitionKey = partition;
            RowKey = row;
            Id = id;

            Data = data;
        }

    }
}

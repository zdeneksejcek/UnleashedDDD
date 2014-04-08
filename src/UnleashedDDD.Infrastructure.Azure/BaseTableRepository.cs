using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;

namespace UnleashedDDD.Infrastructure.Azure
{
    public abstract class BaseTableRepository<TEntity> where TEntity : TableEntity
    {
        private CloudStorageAccount StorageAccount { get; set; }
        private CloudTableClient TableClient { get; set; }

        private CloudTable Table { get; set; }

        protected BaseTableRepository(IAzureConfiguration configuration, string tableName)
        {
            StorageAccount = CloudStorageAccount.Parse(configuration.GetStorageConnectionString());
            TableClient = StorageAccount.CreateCloudTableClient();
            Table = TableClient.GetTableReference(tableName);
        }

        protected TEntity GetEntity(Guid id)
        {
            var retrieveOperation = TableOperation.Retrieve<TEntity>(id.ToString(), id.ToString());
            var retrievedResult = Table.Execute(retrieveOperation);

            return retrievedResult.Result as TEntity;
        }

        protected void SaveSerializedEntity(Guid id, object obj)
        {
            var data = ObjectToByteArray(obj);
            var entity = new SerializedEntity(id.ToString(), id.ToString(), id, data);

            var insertOperation = TableOperation.Insert(entity);
            Table.Execute(insertOperation);
        }

        protected void Save(TEntity entity)
        {
            var insertOperation = TableOperation.Insert(entity);

            Table.Execute(insertOperation);
        }

        // Convert an object to a byte array
        private byte[] ObjectToByteArray(Object obj)
        {
            if (obj == null)
                return null;
            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream();
            bf.Serialize(ms, obj);
            return ms.ToArray();
        }

        // Convert a byte array to an Object
        private Object ByteArrayToObject(byte[] arrBytes)
        {
            MemoryStream memStream = new MemoryStream();
            BinaryFormatter binForm = new BinaryFormatter();
            memStream.Write(arrBytes, 0, arrBytes.Length);
            memStream.Seek(0, SeekOrigin.Begin);
            Object obj = (Object)binForm.Deserialize(memStream);
            return obj;
        }

    }
}

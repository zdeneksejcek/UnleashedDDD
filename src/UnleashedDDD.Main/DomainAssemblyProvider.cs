using System.Reflection;
using OpenDDD;
using UnleashedDDD.Inventory;

namespace UnleashedDDD.Main
{
    public class DomainAssemblyProvider : IDomainAssemblyProvider
    {
        public Assembly[] GetDomainAssemblies()
        {
            return new[] { typeof(InventoryFacade).Assembly };
        }
    }
}

using OpenDDD;
using OpenDDD.Messaging;
using OpenDDD.UnitOfWorkContext;

namespace UnleashedDDD.Core
{
    public class UnleashedCore
    {
        public OrganizationsFacade Organizations { get; private set; }

        public InventoryFacade Inventory { get; private set; }

        private OpenDDD.Core Core { get; set; }

        public UnleashedCore(
            ITypeInstantiator instantiator,
            IStack unitOfWorkStack,
            IHandlerDecisionMaker handlerDecisionMaker,
            IMessageQueue messageQueue)
        {
            Core = new OpenDDD.Core(instantiator, handlerDecisionMaker, unitOfWorkStack, messageQueue);

            Organizations = new OrganizationsFacade();
            Inventory = new InventoryFacade(Core);

            Validate();
        }

        private void Validate()
        {
            
        }

        private void InitDDD()
        {
            //var app = OpenDDD.Application.
        }

    }
}
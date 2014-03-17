using System;
using OpenDDD;
using OpenDDD.RemoteEventQueue;

namespace UnleashedDDD.Infrastructure.InMemory.Multitenent
{
    public class Queue : IRemoteEventQueue
    {
        private IOrganizationContextFactory _contextFactory;

        public Queue(IOrganizationContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public void Enqueue(Event @event)
        {
            var context = _contextFactory.GetContext();

            Console.WriteLine(string.Format("{0} Remote queue event added: " + @event.GetType().Name, context.OrganizationId));
        }
    }
}
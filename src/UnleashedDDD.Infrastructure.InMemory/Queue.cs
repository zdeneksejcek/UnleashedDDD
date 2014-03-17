using System;
using OpenDDD;
using OpenDDD.RemoteEventQueue;

namespace UnleashedDDD.Infrastructure.InMemory
{
    public class Queue : IRemoteEventQueue
    {
        public void Enqueue(Event @event)
        {
            Console.WriteLine(string.Format("Remote queue event added: " + @event.GetType().Name));
        }
    }
}
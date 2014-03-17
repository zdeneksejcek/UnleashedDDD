using System;
using OpenDDD;

namespace UnleashedDDD.Worker
{
    public class HandlersConfiguration : IHandlerDecisionMaker
    {
        public bool ShouldBeHandled(Type type)
        {
            return false;
        }
    }
}
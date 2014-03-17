using System;
using OpenDDD;

namespace UnleashedApplication
{
    public class HandlersConfiguration : IHandlerDecisionMaker
    {
        public bool ShouldBeHandled(Type type)
        {
            return false;
        }
    }
}

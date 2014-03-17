using System.Diagnostics;

namespace UnleashedDDD.Organizations.Domain.Model.User
{
    [DebuggerDisplay("{Value}")]
    public class UserEmail : OpenDDD.Common.EmailValueObject
    {
        public UserEmail(string value) : base(value)
        {
            
        }
    }
}

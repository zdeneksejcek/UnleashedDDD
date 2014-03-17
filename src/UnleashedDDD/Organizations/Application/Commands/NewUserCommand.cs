using OpenDDD;

namespace UnleashedDDD.Organizations.Application.Commands
{
    public class NewUserCommand : Command
    {
        public string Email { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public NewUserCommand(string email, string firstName, string lastName)
        {
            Email = email;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}

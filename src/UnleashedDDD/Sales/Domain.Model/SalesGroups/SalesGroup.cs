using OpenDDD;

namespace UnleashedDDD.Sales.Domain.Model.SalesGroups
{
    public class SalesGroup : Entity
    {
        public SalesGroupId Id { get; private set; }

        public SalesGroupName Name { get; private set; }

        private bool _isObsolete = false;
        public bool IsObsolete
        {
            get { return _isObsolete; }
            set { _isObsolete = value; }
        }
    }
}

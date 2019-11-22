
using Entity;
using FirstUseEntityFrameWork;

namespace DomainToEF
{
    class PartyController
    {
        private IDatabase<Party> database;

        public PartyController()
        {
            database = new PartyControllerEF();
        }

        public void CreateParty(Party party)
        {
            database.Create(party);
        }
    }
}

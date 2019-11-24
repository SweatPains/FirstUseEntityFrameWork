using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using FirstUseEntityFrameWork;

namespace DomainLayer
{
    class PartyController
    {
        PartyManagerEF partyEFContext = new PartyManagerEF();

        public void CreateParty(Party party)
        {
            partyEFContext.Create(party);
        }

        public List<Party> ReadAllParty()
        {
            return partyEFContext.Read();
        }
    }
}

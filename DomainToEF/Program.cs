using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entity;

namespace DomainToEF
{
    class Program
    {
        static void Main(string[] args)
        {
            GuestController gCtrl = new GuestController();
            PartyController pCtrl = new PartyController();

            Guest guest = new Guest();
            guest. Name = "Hello From Domain";
            gCtrl.CreateGuest(guest);

            Party party = new Party();
            party.Name = "Hello form Domain";
            pCtrl.CreateParty(party);
        }
    }
}

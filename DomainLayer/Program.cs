using System;
using FirstUseEntityFrameWork;
using EntityLayer;
using System.Collections.Generic;

namespace DomainLayer
{
    class Program
    {
        static void Main(string[] args)
        {

            PartyController partyController = new PartyController();
            Party party = new Party();
            party.Name = "Hellom From Domain: Party";
            partyController.CreateParty(party);


        }
    }
}

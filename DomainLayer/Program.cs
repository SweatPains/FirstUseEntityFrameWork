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
            /*
            PartyController partyController = new PartyController();
            Party partyObj = new Party();
            partyObj.Name = "blank";
            partyObj.PolyClass = new PolyClass();

            partyController.CreateParty(partyObj);
            */
            
            
            PolyClassController polyController = new PolyClassController();
            PolyClass polyObj = new PolyClass();
            List<Party> partyList = new List<Party>();

            for (int i = 0; i < 5; i++)
            {
                Party partyObj = new Party();
                partyObj.Name = $"blank{ i}";
                partyList.Add(partyObj);

            }

            polyObj.Parties = partyList;
            polyController.CreatePoly(polyObj);
            
        }
    }
}

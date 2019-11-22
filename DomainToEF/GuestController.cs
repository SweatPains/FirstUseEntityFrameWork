using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using FirstUseEntityFrameWork;

namespace DomainToEF
{
    class GuestController
    {
        private IDatabase<Guest> database;

        public GuestController()
        {
            database = new GuestControllerEF();
        }

        public void CreateGuest(Guest guest)
        {
            database.Create(guest);
        }

    }
}

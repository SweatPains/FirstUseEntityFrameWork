using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace FirstUseEntityFrameWork
{
    public class GuestControllerEF: IDatabase<Guest>
    {
        private Model dbContext;

        public GuestControllerEF()
        {
            dbContext = new Model();
        }

        public void Create(Guest entity)
        {
            dbContext.Guest.Add(entity);
            dbContext.SaveChanges();
        }
    }
}

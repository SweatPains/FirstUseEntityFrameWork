using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace FirstUseEntityFrameWork
{
    public class PartyControllerEF : IDatabase<Party>
    {
        private Model dbContext;

        public PartyControllerEF()
        {
            dbContext = new Model();
        }

        public void Create(Party entity)
        {
            dbContext.Party.Add(entity);
            dbContext.SaveChanges();
        }
    }
}

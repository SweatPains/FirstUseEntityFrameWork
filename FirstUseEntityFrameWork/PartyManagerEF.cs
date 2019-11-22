using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;

namespace FirstUseEntityFrameWork
{
    public class PartyManagerEF
    {
        private ModelOne model = new ModelOne();

        public void Create(Party party)
        {
            model.Parties.Add(party);
            model.SaveChanges();
        }
    }
}

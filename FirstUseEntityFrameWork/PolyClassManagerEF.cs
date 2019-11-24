using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;

namespace FirstUseEntityFrameWork
{
    public class PolyClassManagerEF
    {
        private ModelOne model = new ModelOne();

        public void Create(PolyClass polyClass)
        {
            model.PolyClasses.Add(polyClass);
            model.SaveChanges();
        }
    }
}

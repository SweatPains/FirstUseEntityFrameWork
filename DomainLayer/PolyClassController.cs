using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstUseEntityFrameWork;
using EntityLayer;
namespace DomainLayer
{
    class PolyClassController
    {
        private PolyClassManagerEF EFContextManager; 

        public PolyClassController()
        {
            EFContextManager = new PolyClassManagerEF();
        }

        public void CreatePoly(PolyClass poly)
        {
            EFContextManager.Create(poly);
        }
    }
}

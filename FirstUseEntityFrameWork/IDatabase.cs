using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstUseEntityFrameWork
{
   public interface IDatabase<T>
    {
        void Create(T entity);
    }
}

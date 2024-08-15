using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FNI_Libray
{
   public  interface FNIinterface
    {
        public IEnumerable<FNImodel> Showall();
        public void create(FNImodel set);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FNI_Libray
{
   public  class FNIRepostry:FNIinterface
    {
        private readonly FNIDbcontext reference;
        public FNIRepostry(FNIDbcontext refer)
        {
            reference = refer;
        }
        public IEnumerable<FNImodel> Showall()
        {
            return reference.FNIcompanydetils.ToList();
        }
        public void create(FNImodel set)
        {
            reference.Add<FNImodel>(set);
            reference.SaveChanges();
        }
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FNI_Libray
{
    public class FNIDbcontext:DbContext
    {
        public FNIDbcontext(DbContextOptions inject) : base(inject)
        {
        }
        public virtual DbSet<FNImodel> FNIcompanydetils { get; set; }
    }
}

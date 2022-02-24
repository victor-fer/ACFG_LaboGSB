using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACFG_LaboGSB.Classes
{
    public partial class MyContext : DbContext
    {
        public virtual DbSet<Visiteur> Visiteur { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=ACFG_LaboGSB;persist security info=True;User id=sa;Password=info;");
        }
    }
}

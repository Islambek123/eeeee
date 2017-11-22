using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class EFContext : DbContext
    {
        public EFContext() : base("IEatBread")
        {

        }

        public DbSet<Map> Maps { get; set; }
    }
}

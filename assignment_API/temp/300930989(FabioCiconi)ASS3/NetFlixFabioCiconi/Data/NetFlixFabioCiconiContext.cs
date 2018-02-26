using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NetFlixFabioCiconi.Models
{
    public class NetFlixFabioCiconiContext : DbContext
    {
        public NetFlixFabioCiconiContext (DbContextOptions<NetFlixFabioCiconiContext> options)
            : base(options)
        {
        }

        public DbSet<NetFlixFabioCiconi.Models.Movies> Movies { get; set; }
    }
}

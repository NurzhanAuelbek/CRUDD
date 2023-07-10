using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDD.Models
{
    public class TranzakciaContext : DbContext
    {
        //konstructor
        public TranzakciaContext(DbContextOptions<TranzakciaContext> options):base(options)
        {

        }

        public DbSet<Tranzakcia> Tranzakcias { get; set; }
    }
}

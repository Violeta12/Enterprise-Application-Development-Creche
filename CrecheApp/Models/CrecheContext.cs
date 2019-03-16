using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CrecheApp.Models
{
    public class CrecheContext : DbContext
    {

        public CrecheContext(DbContextOptions<CrecheContext> options)
                : base(options)
        { }

        public DbSet<CrecheClass> Creche { get; set; }

    }
}

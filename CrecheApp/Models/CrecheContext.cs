using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

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

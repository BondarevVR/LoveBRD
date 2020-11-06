using LoveBRD.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoveBRD.Persistance
{
    public class AppDBContext: DbContext
    {
        public DbSet<Models._Type> Types { get; set; }
        public DbSet<Feature> Features { get; set; }
        public AppDBContext(DbContextOptions<AppDBContext> options)
            :base(options)
        {

        }
    }
}

using LoveBRD.Core.Models;
using LoveBRD.Core.Models.ApartmentModel;
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
        public DbSet<_Type> Types { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Apartment> Apartments { get; set; }
        public AppDBContext(DbContextOptions<AppDBContext> options)
            :base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<ApartmentFeature>().HasKey(af => 
                new { af.ApartmentId, af.FeatureId });
            modelBuilder.Entity<Contacts>().HasKey(c => new { c.ApartmentId });
        }
    }
}

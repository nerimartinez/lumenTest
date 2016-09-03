using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLayer.Models
{
    public class LumenContext : DbContext
    {
        public LumenContext() : base ("name=DefaultConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Policy> Policies { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Device> Devices { get; set; }
    }
}

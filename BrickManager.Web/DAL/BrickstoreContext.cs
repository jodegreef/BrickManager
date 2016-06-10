using BrickManager.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace BrickManager.Web.DAL
{
    public class BrickstoreContext : DbContext
    {
        static BrickstoreContext()
        {
            Database.SetInitializer<BrickstoreContext>(new CreateDatabaseIfNotExists<BrickstoreContext>());
        }

        public BrickstoreContext()
            : base("Name=BrickstoreContext")
        {
        }

        public DbSet<LegoSet> LegoSets { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();
        }
    }
}

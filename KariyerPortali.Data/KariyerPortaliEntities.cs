using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KariyerPortali.Model;
using KariyerPortali.Data.Configuration;

namespace KariyerPortali.Data
{
    public class KariyerPortaliEntities : DbContext
    {
        public KariyerPortaliEntities() : base("KariyerPortaliEntities") { }

        public DbSet<Cv> Cvs { get; set; }

        public virtual void Commit()
        {
            base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CvConfiguration());
        }
    }
}

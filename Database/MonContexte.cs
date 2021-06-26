using BiblioClass.Entity;
using BiblioClass.Mapping;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioClass
{
    public class MonContexte : DbContext
    {
        public MonContexte() : base("name=Database1")
        {
            Database.SetInitializer<MonContexte>(null);
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasDefaultSchema("dbo");
            modelBuilder.Configurations.Add(new OffreFluent());
            modelBuilder.Configurations.Add(new StatutFluent());
            modelBuilder.Configurations.Add(new PostulationFluent());
            modelBuilder.Configurations.Add(new EmployeFluent());
            modelBuilder.Configurations.Add(new ExperienceFluent());
            modelBuilder.Configurations.Add(new FormationFluent());
        }

        public IDbSet<Offre> Offres { get; set; }

        public IDbSet<Statut> Statuts { get; set; }
       
        public IDbSet<Postulation> Postulations { get; set; }
        
        public IDbSet<Employe> Employes { get; set; }

        public IDbSet<Experience> Experiences { get; set; }

        public IDbSet<Formation> Formations { get; set; }

    }
}

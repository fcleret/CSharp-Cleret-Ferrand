using BiblioClass.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioClass.Mapping
{
    public class EmployeFluent : EntityTypeConfiguration<Employe>
    {
        public EmployeFluent()
        {
            ToTable("APP_EMPLOYE");
            HasKey(o => o.Id);

            Property(o => o.Id).IsRequired().HasColumnName("EMP_ID");
            Property(o => o.Nom).IsRequired().HasMaxLength(250).HasColumnName("EMP_NOM");
            Property(o => o.Prenom).IsRequired().HasColumnName("EMP_PRENOM");
            Property(o => o.DateNaissance).IsRequired().HasColumnName("EMP_DATENAISSANCE");
            Property(o => o.Anciennete).IsRequired().HasColumnName("EMP_ANCIENNETE");
            Property(o => o.Biographie).IsRequired().HasColumnName("EMP_BIOGRAPHIE");

            HasMany(o => o.Experiences).WithRequired(e => e.Employe).HasForeignKey(e => e.EmployeId);
            HasMany(o => o.Formations).WithRequired(e => e.Employe).HasForeignKey(e => e.EmployeId);
            HasMany(o => o.Postulations).WithRequired(e => e.Employe).HasForeignKey(e => e.EmployeId);
        }
    }
}

using BiblioClass.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioClass.Mapping
{
    public class StatutFluent : EntityTypeConfiguration<Statut>
    {
        public StatutFluent()
        {
            ToTable("APP_STATUT");
            HasKey(o => o.Id);

            Property(o => o.Id).IsRequired().HasColumnName("STA_ID").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(o => o.Libelle).IsRequired().HasMaxLength(250).HasColumnName("STA_LIBELLE");

            HasMany(o => o.Offres).WithRequired(e => e.Statut).HasForeignKey(e => e.StatutId);
        }
    }
}

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
    public class OffreFluent : EntityTypeConfiguration<Offre>
    {
        public OffreFluent()
        {
            ToTable("APP_OFFRE");
            HasKey(o => o.Id);

            Property(o => o.Id).IsRequired().HasColumnName("OFF_ID").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(o => o.Intitule).IsRequired().HasMaxLength(250).HasColumnName("OFF_INTITULE");
            Property(o => o.Date).IsRequired().HasColumnName("OFF_DATE");
            Property(o => o.Salaire).IsRequired().HasColumnName("OFF_SALAIRE");
            Property(o => o.Description).IsRequired().HasMaxLength(250).HasColumnName("OFF_DESCRIPTION");
            Property(o => o.Responsable).IsRequired().HasColumnName("OFF_RESPONSABLE");

            Property(o => o.StatutId).IsRequired().HasColumnName("STA_ID");

            HasRequired(o => o.Statut).WithMany().HasForeignKey(o => o.StatutId);
        }
    }
}

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
    public class PostulationFluent : EntityTypeConfiguration<Postulation>
    {
        public PostulationFluent()
        {
            ToTable("APP_POSTULATION");
            HasKey(o => new { o.EmployeId, o.OffreId });

            Property(o => o.EmployeId).IsRequired().HasColumnName("EMP_ID").HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(o => o.OffreId).IsRequired().HasColumnName("OFF_ID").HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(o => o.Date).IsRequired().HasColumnName("POS_DATE");
            Property(o => o.Statut).IsRequired().HasColumnName("POS_STATUT");

            HasRequired(o => o.Employe).WithMany().HasForeignKey(o => o.EmployeId);
            HasRequired(o => o.Offre).WithMany().HasForeignKey(o => o.OffreId);
        }
    }
}

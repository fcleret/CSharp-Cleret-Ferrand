using BiblioClass.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioClass.Mapping
{
    public class FormationFluent : EntityTypeConfiguration<Formation>
    {
        public FormationFluent()
        {
            ToTable("APP_FORMATION");
            HasKey(o => o.Id);

            Property(o => o.Id).IsRequired().HasColumnName("FOR_ID");
            Property(o => o.Intitule).IsRequired().HasMaxLength(250).HasColumnName("FOR_INTITULE");
            Property(o => o.Date).IsRequired().HasColumnName("FOR_DATE");

            Property(o => o.EmployeId).IsRequired().HasColumnName("EMP_ID");
            HasRequired(o => o.Employe).WithMany().HasForeignKey(o => o.EmployeId);
        }

    }   
}

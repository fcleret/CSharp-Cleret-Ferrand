using BiblioClass.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioClass.Mapping
{
    public class ExperienceFluent : EntityTypeConfiguration<Experience>
    {
        public ExperienceFluent()
        {
            ToTable("APP_EXPERIENCE");
            HasKey(o => o.Id);

            Property(o => o.Id).IsRequired().HasColumnName("EXP_ID");
            Property(o => o.Intitule).IsRequired().HasMaxLength(250).HasColumnName("EXP_INTITULE");
            Property(o => o.Date).IsRequired().HasColumnName("EXP_DATE");

            Property(o => o.EmployeId).IsRequired().HasColumnName("EMP_ID");
            HasRequired(o => o.Employe).WithMany().HasForeignKey(o => o.EmployeId);
        }

    }   
}

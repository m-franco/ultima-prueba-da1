using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace ultima_prueba_da1
{
    class DoctorEntityConfiguration : EntityTypeConfiguration<Hospital>
    {
        public DoctorEntityConfiguration()
        {
            this.ToTable("Doctors");
            
            this.Property(doctor => doctor.Name).IsRequired();
        }
    }
}


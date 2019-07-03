using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace ultima_prueba_da1
{
    class HospitalEntityConfiguration : EntityTypeConfiguration<Hospital>
    {
        public HospitalEntityConfiguration()
        {
            this.ToTable("Hospitals");
            
            this.Property(hospital => hospital.Name).IsRequired();
        }
    }
}


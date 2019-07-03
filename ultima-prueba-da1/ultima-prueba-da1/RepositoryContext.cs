using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Data.Entity;

namespace ultima_prueba_da1
{

    public class RepositoryContext : DbContext
    {
        public DbSet<Hospital> Hospitals { get; set; }
        public DbSet<Doctor> Doctors { get; set; }

        public RepositoryContext()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<RepositoryContext>());
            var instance = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new HospitalEntityConfiguration());
            modelBuilder.Configurations.Add(new DoctorEntityConfiguration());
        }
    }
}

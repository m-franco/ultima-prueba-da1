using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ultima_prueba_da1
{
    public class HospitalDataAccessBD
    {

        public void Insert(Hospital hospital)
        {
            using (var context = new RepositoryContext())
            {
                context.Hospitals.Add(hospital);
                context.SaveChanges();
            }
        }

        public void Delete(Hospital hospital)
        {

            using (var context = new RepositoryContext())
            {
                Hospital hospitalToDelete = context.Hospital.First(h => h.Name == hospital.Name);
                context.SaveChanges();
            }

        }

        public Hospital GetHospital(string name)
        {
            using (var context = new RepositoryContext())
            {
                return context.Hospitals.FirstOrDefault(h => h.Name == name);
               
            }
        }

        public void Modify(string nameHospital, Hospital updatedHospital)
        {
                using (var context = new RepositoryContext())
                {
                    Hospital hospital = context.Hospitals.FirstOrDefault(h => h.Name == nameHospital);

                    hospital.Name = updatedHospital.Name;
                    hospital.Address = updatedHospital.Address;
                    context.SaveChanges();
                }
        }
    }
}


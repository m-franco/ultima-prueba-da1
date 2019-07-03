using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ultima_prueba_da1
{
    public class DoctorDataAccessBD
    {

        public void Insert(Doctor doctor)
        {
            using (var context = new RepositoryContext())
            {
                context.Doctors.Add(doctor);
                context.SaveChanges();
            }
        }

        public void Delete(Doctor doctor)
        {

            using (var context = new RepositoryContext())
            {
                Doctor doctorToDelete = context.Doctors.First(d => d.Name == doctor.Name);
                context.SaveChanges();
            }

        }

        public Doctor Getdoctor(string name)
        {
            using (var context = new RepositoryContext())
            {
                return context.Doctors.FirstOrDefault(d => d.Name == name);
               
            }
        }

        public void Modify(string namedoctor, Doctor updatedDoctor)
        {
                using (var context = new RepositoryContext())
                {
                    Doctor doctor = context.Doctors.FirstOrDefault(h => h.Name == namedoctor);

                    doctor.Name = updatedDoctor.Name;
                    doctor.DateOfBirth = updatedDoctor.DateOfBirth;
                    doctor.Specialty = updatedDoctor.Specialty;
                    context.SaveChanges();
                }
        }
    }
}


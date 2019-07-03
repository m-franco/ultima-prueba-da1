using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ultima_prueba_da1
{
    public class Hospital
    {
        public int Id { get; set; }

        public String Name { get; set; }

        public String Address { get; set; }

        public List<Doctor> DoctorList { get; set; }

    }
}

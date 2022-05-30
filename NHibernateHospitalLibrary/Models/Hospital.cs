using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateHospitalLibrary.Models
{
    public class Hospital
    {
        public virtual List<Doctor>? Doctors { get; set; }
    }
}

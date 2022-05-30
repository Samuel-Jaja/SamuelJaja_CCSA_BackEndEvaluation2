using NHibernateHospitalLibrary.IServicesRendered;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateHospitalLibrary.Models
{
    public class Doctor : Worker, IDoctor
    {
        public Doctor(string tagNumber, DateOnly resumptionDate, Hospital hospital) : base(tagNumber, resumptionDate, hospital)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateHospitalLibrary.Models
{
   public class Worker:Person
    {

        public Worker(string tagNumber, DateOnly resumptionDate, Hospital hospital)
        {
            TagNumber = tagNumber;
            ResumptionDate = resumptionDate;
            Hospital = hospital;
            

        }
        public virtual string TagNumber { get; set; }
        public virtual DateOnly ResumptionDate { get; set; }
        public virtual DateOnly RetirementDate { get; set; }
        public virtual Hospital Hospital { get; set; }
    }
}

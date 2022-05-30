using NHibernateHospitalLibrary.Enumeration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateHospitalLibrary.Models
{
    public class Person:EntityBaseModel
    {
        public virtual string? Name { get; set; }
        public virtual Sex Sex { get; set; }
        public virtual string? PhoneNumber { get; set; }

        private DateTime dateOfBirth;
        public virtual DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set
            {
                if (value < DateTime.Now)
                {
                    dateOfBirth = value;
                }

            }
        }
        public virtual string? Address { get; set; }
        public virtual string? Nationality { get; set; }

       
    }
}

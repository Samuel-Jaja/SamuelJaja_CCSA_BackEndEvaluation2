using FluentNHibernate.Mapping;
using NHibernateHospitalLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateHospitalLibrary.Mapping
{
    public class HospitalMap:ClassMap<Hospital>
    {
        public HospitalMap()
        {

        }
    }
}

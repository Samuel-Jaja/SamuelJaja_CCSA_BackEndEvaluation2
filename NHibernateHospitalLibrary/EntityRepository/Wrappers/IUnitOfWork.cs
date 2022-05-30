using NHibernateHospitalLibrary.EntityRepository.IModelRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateHospitalLibrary.EntityRepository.Wrappers
{
    public interface IUnitOfWork
    {

        IAccountantRepo Accountant { get; }
        IDoctorRepo DoctorRepo { get; }
    }
}

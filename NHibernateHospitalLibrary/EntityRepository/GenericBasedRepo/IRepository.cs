using NHibernateHospitalLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateHospitalLibrary.EntityRepository.GenericBasedRepo
{
    public interface IRepository<T> where T : EntityBaseModel
    {
        bool IsExist(int id);
        T GetById(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> FindByPredicate(Expression<Func<T, bool>> predicate);
        void AddEntity(T entity);
        void UpdateEntity(T entity);
        void RomoveEntity(int id);
    }
}

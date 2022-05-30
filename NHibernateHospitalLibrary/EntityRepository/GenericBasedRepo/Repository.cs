using NHibernate;
using NHibernateHospitalLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateHospitalLibrary.EntityRepository.GenericBasedRepo
{
    public class Repository<T>:IRepository<T> where T : EntityBaseModel
    {
        protected ISession _session;
        public Repository(ISession session)
        {
            _session = session;
        }
        public virtual void AddEntity(T entity)
        {
            _session.Save(entity);
        }


        public IEnumerable<T> FindByPredicate(Expression<Func<T, bool>> predicate)
        {
            return _session.Query<T>().Where(predicate);
        }

        public IEnumerable<T> GetAll()
        {
            return _session.Query<T>();
        }

        public T GetById(int id)
        {
            var temp = _session.Query<T>().FirstOrDefault(x => x.Id == id);
            if (temp != null)
            {
                return temp;
            }
            else
            {
                throw new NullReferenceException("Item not found");
            }
        }
        public bool IsExist(int id)
        {
            return _session.Query<T>().Where(x => x.Id == id) != null;
        }

        public virtual void RomoveEntity(int id)
        {
            var p = _session.Query<T>().FirstOrDefault(x => x.Id == id);
            if (p != null)
            {
                _session.Delete(p);
            }
            else
            {
                throw new NullReferenceException("Item not found");
            }

        }

        public virtual void UpdateEntity(T entity)
        {
            if (IsExist(entity.Id))
            {
                _session.Update(entity);
            }
            else
            {
                throw new NullReferenceException("Item not found");
            }

        }
    }
}

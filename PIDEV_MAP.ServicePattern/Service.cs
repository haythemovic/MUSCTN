using Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MUSCTN.ServicePattern
{
    public class Service<TEntity> : IService<TEntity> where TEntity : class
    {
        IUnitOfWork utwk;

        protected Service(IUnitOfWork utwk)
        {
            this.utwk = utwk;
        }


        public void Add(TEntity entity)
        {
            utwk.getRepository<TEntity>().Add(entity);
        }

        public void Delete(Expression<Func<TEntity, bool>> where)
        {
            utwk.getRepository<TEntity>().Delete(where);
        }

        public void Delete(TEntity entity)
        {
            utwk.getRepository<TEntity>().Delete(entity);
        }

        public TEntity Get(Expression<Func<TEntity, bool>> where)
        {
            return utwk.getRepository<TEntity>().Get(where);
        }

        public TEntity GetById(string id)
        {
            return utwk.getRepository<TEntity>().GetById(id);
        }

        public TEntity GetById(long id)
        {
            return utwk.getRepository<TEntity>().GetById(id);
        }

        public virtual IEnumerable<TEntity> GetMany(Expression<Func<TEntity, bool>> filter = null, Expression<Func<TEntity, bool>> orderBy = null)
        {
            //  return _repository.GetAll();
            return utwk.getRepository<TEntity>().GetMany(filter, orderBy);
        }



        public void Update(TEntity entity)
        {
            utwk.getRepository<TEntity>().Update(entity);
        }
        public void Commit()
        {
            try { utwk.Commit(); }
            catch (Exception ex) { throw; }
        }
        public void Dispose()

        {
            utwk.Dispose();
        }
    }
}

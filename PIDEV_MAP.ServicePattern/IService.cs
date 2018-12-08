using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MUSCTN.ServicePattern
{
    public interface IService<TEntity> : IDisposable where TEntity : class
    {
        void Add(TEntity entity);
        void Delete(TEntity entity);
        void Delete(Expression<Func<TEntity, bool>> where);
        void Update(TEntity entity);
        TEntity Get(Expression<Func<TEntity, bool>> where);
        TEntity GetById(long id);
        TEntity GetById(string id);
        IEnumerable<TEntity> GetMany(Expression<Func<TEntity, bool>> where = null, Expression<Func<TEntity, bool>> orderBy = null);

        void Commit();
    }

}

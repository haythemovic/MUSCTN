using MUSCTN.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private MapContext datacontext;
        private IDataBaseFactory dbFactory;
        public UnitOfWork(IDataBaseFactory dbFactory)
        {
            this.dbFactory = dbFactory;
            datacontext = dbFactory.DataContext;
        }
        public void Commit()
        {
            datacontext.SaveChanges();
        }
        public void Dispose()
        {
            datacontext.Dispose();
        }

        public IRepositoryBase<T> getRepository<T>() where T : class
        {
            return new RepositoryBase<T>(dbFactory);
        }
    }
}

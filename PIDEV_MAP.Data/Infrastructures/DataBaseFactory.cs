using MUSCTN.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Infrastructure
{
    public class DataBaseFactory :Disposable, IDataBaseFactory
    {
        private MapContext dataContext;
        public DataBaseFactory()
        {
            dataContext=new MapContext();
        }
        public MapContext DataContext
        {
            get
            {
                return dataContext;
            }
        }

        protected override void DisposeCore()
        {
            if(DataContext!=null)
            DataContext.Dispose();
        }
    }
}

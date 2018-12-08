using MUSCTN.Domain.entities;
using MUSCTN.Service.Services.Interfaces;
using MUSCTN.ServicePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Infrastructure;

namespace MUSCTN.Service.Services.Implementation
{
    public class UserService : Service<User>, IUserService
    {
        private static IDataBaseFactory databaseFactory = new DataBaseFactory();
        private static IUnitOfWork unitOfWork = new UnitOfWork(databaseFactory);

        public UserService() : base(unitOfWork)
        {
        }


    }

}

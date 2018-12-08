using MUSCTN.Domain.entities;
using MUSCTN.ServicePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUSCTN.Service.Services.Interfaces
{
    public interface IUserService  :IService<User>, IDisposable
    {


    }
}

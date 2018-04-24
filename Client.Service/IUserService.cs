using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Service
{
     public interface IUserService
    {
         Task<UserServiceModel> GetAsync();
         Task<UserServiceModel> SetAsync(UserServiceModel user);

    }
}

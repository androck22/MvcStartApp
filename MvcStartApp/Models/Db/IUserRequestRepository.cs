using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcStartApp.Models.Db
{
    public interface IUserRequestRepository
    {
        Task AddRequest(UserRequest userRequest);
        Task<UserRequest[]> GetRequests();
    }
}

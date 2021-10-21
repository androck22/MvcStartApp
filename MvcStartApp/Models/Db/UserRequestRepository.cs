using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcStartApp.Models.Db
{
    public class UserRequestRepository : IUserRequestRepository
    {
        private readonly UserRequestContext _context;

        public UserRequestRepository(UserRequestContext context)
        {
            _context = context;
        }

        public async Task AddRequest(UserRequest userRequest)
        {
            var entry = _context.Entry(userRequest);

            if (entry.State == EntityState.Detached)
                await _context.UserRequests.AddAsync(userRequest);

            await _context.SaveChangesAsync();
        }

        public async Task<UserRequest[]> GetRequests()
        {
            return await _context.UserRequests.ToArrayAsync();
        }
    }
}

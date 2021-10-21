using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcStartApp.Models.Db
{
    public class UserRequestContext : DbContext
    {
        public DbSet<UserRequest> UserRequests { get; set; }

        public UserRequestContext(DbContextOptions<UserRequestContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<UserRequest>().ToTable("UserRequests");
        }
    }
}

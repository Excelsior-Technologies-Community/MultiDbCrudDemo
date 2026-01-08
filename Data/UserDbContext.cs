using Microsoft.EntityFrameworkCore;
using MultiDbCrudDemo.Models;

namespace MultiDbCrudDemo.Data
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options)
            : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}

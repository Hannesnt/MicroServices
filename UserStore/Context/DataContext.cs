using Microsoft.EntityFrameworkCore;
using UserStore.Entities;

namespace UserStore.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<UserEntity> Users { get; set; }
    }
}

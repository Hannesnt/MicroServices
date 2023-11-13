using Microsoft.EntityFrameworkCore;
using Shared.Generics;
using UserStore.Context;
using UserStore.Entities;

namespace UserStore.Repositories
{
    public class UserRepository : Repository<UserEntity, DataContext>
    {
        public UserRepository(DbContext context) : base(context)
        {
        }
    }
}

using ArticleStore.Entities;
using Microsoft.EntityFrameworkCore;

namespace ArticleStore.Context;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions options) : base(options)
    {

    }
    public DbSet<ArticleEntity> Articles { get; set; }
}

using ArticleStore.Context;
using ArticleStore.Entities;
using Microsoft.EntityFrameworkCore;
using Shared.Generics;

namespace ArticleStore.Repositories;

public class ArticleRepository : Repository<ArticleEntity, DataContext>
{
    public ArticleRepository(DbContext context) : base(context)
    {
    }
}

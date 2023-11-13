using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
namespace Shared.Generics;

public abstract class Repository<TEntity, TDbContext> where TEntity : class where TDbContext : DbContext
{
    private readonly DbContext _context;

    public Repository(DbContext context)
    {
        _context = context;
    }

    public async Task<TEntity> AddAsync(TEntity entity)
    {
        try
        {
            await _context.Set<TEntity>().AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); }
        return null!;
    }
    public async Task<TEntity> AddMewAsync(TEntity entity)
    {
        try
        {
            await _context.Set<TEntity>().AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); }
        return null!;
    }
}

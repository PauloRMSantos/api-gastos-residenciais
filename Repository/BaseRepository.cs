using gastosResidenciais.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace gastosResidenciais.Repository;

public class BaseRepository<T> : IRepository<T> where T : class
{
    protected readonly AppDbContext _context;
    protected readonly DbSet<T> _dbSet;

    public BaseRepository(AppDbContext context)
    {
        _context = context;
        _dbSet = context.Set<T>();
    }

    public async Task<IEnumerable<T>> GetAllAsync() => 
        await _dbSet.ToListAsync();
    public async Task<T> GetByIdAsync(int id) => 
        await _dbSet.FindAsync(id);
    public async Task addAsync(T entity) =>
        await  _dbSet.AddAsync(entity);
    public async Task updateAsync(T entity) =>
         _dbSet.Update(entity);
    public async Task deleteAsync(T entity) =>
        _dbSet.Remove(entity);
}
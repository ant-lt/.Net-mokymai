using BookWebApiRepo_MSSQL_EF.Data;
using BookWebApiRepo_MSSQL_EF.Repositories.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BookWebApiRepo_MSSQL_EF.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly BookContext _db;
        private DbSet<TEntity> _dbSet;

        public Repository(BookContext db)
        { 
            _db = db;
            _dbSet = _db.Set<TEntity>();
        }

        public async Task CreateAsync(TEntity entity)
        {
            _dbSet.Add(entity);
            await SaveAsync();
        }

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> filter, bool tracked = true)
        {
            IQueryable<TEntity> query = _dbSet;

            if (!tracked)
            {
                query = query.AsNoTracking();
            }

            query = query.Where(filter);

            return await query.FirstOrDefaultAsync();
        }

        public async Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>>? filter = null)
        {
            IQueryable<TEntity> query = _dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            return await query.ToListAsync();
        }

        public async Task RemoveAsync(TEntity entity)
        {
            _dbSet.Remove(entity);
            await SaveAsync();
        }

        public async Task SaveAsync()
        {
            await _db.SaveChangesAsync();
        }
    }
}

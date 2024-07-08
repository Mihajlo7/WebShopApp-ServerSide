using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using GenericEntity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace GenericInfrastructure
{

    public class EFGenericRepository<TContext,TEntity> : IRepository<TEntity> 
        where TContext : DbContext
        where TEntity : IEntity
    {
        private readonly TContext _dbContext;
        private readonly DbSet<TEntity> _dbSet;

        public EFGenericRepository(TContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet=_dbContext.Set<TEntity>();
        }

        public TEntity Add(TEntity entity)
        {
            return _dbSet.Add(entity).Entity;
        }

        public void Delete(TEntity entity)
        {
            _dbSet.Remove(entity);
        }

        public Task<List<TEntity>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            return _dbSet.ToListAsync(cancellationToken);
        }

        public Task<List<TEntity>> GetByExpressionAsync(Expression<Func<TEntity, bool>> expression, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null, CancellationToken cancellationToken = default)
        {
            var query= expression !=null ? _dbSet.Where(expression) : _dbSet;

            return orderBy !=null ? orderBy(query).ToListAsync(cancellationToken): query.ToListAsync(cancellationToken);
        }

        public async Task<TEntity?> GetByIdAsync(Guid id)
        {
            return await _dbSet.FindAsync(id);
        }

        public IQueryable<TEntity> GetQueryable(Expression<Func<TEntity, bool>> expression, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null)
        {
            var query=_dbSet.Where(expression);
            return orderBy != null ? orderBy(query) : query;
        }

        public Task<TEntity?> GetSingleOrDefaultAsync(Expression<Func<TEntity, bool>> expression)
        {
            return _dbSet.SingleOrDefaultAsync(expression);
        }

        public void Update(TEntity entity)
        {
            _dbSet.Update(entity);
        }
    }
}

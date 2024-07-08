using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using GenericEntity;

namespace GenericInfrastructure
{
    public interface IRepository<TEntity>
    {
        Task<TEntity?> GetByIdAsync(Guid id);
        IQueryable<TEntity> GetQueryable(Expression<Func<TEntity,bool>> expression,Func<IQueryable<TEntity>,IOrderedQueryable<TEntity>>? orderBy=default);
        Task<List<TEntity>> GetByExpressionAsync(Expression<Func<TEntity, bool>> expression, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = default, CancellationToken cancellationToken = default);
        Task<List<TEntity>> GetAllAsync(CancellationToken cancellationToken = default);
        Task<TEntity?> GetSingleOrDefaultAsync(Expression<Func<TEntity, bool>> expression);
        
        TEntity Add (TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);

    }
}

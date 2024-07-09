using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using GenericEntity;
using Microsoft.EntityFrameworkCore;

namespace GenericInfrastructure
{
    public class UnitOfWork<TContext> : IUnitOfWork<TContext> where TContext : DbContext
    {
        private readonly TContext _context;
        private readonly Dictionary<Type, object> _repositories = new();

        public UnitOfWork(TContext context)
        {
            _context = context;
        }
        public async Task<int> CommitChanges()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public IRepository<TEntity> GetRepository<TEntity>() where TEntity : IEntity
        {
            var type = typeof(TEntity);

            if(!_repositories.ContainsKey(type)) 
            {
                var repository=new EFGenericRepository<TContext,TEntity>(_context);
                _repositories.Add(type, repository);
                return repository;
            }

            return (IRepository < TEntity >) _repositories[type];
        }
    }
}

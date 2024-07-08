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
    public class UnitOfWork<TContext> : IUnitOfWork where TContext : DbContext
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
            throw new NotImplementedException();
        }

        public IRepository<TEntity> GetRepository<TEntity>() where TEntity : IEntity
        {
            var type = typeof(TEntity);

            if(!_repositories.ContainsKey(type)) 
            {
                var repositoryType = typeof(EFGenericRepository<TContext, TEntity>);
                var repositoryInstance= Activator.CreateInstance(repositoryType);
                _repositories.Add(type, repositoryInstance);
            }

            return (IRepository < TEntity >) _repositories[type];
        }
    }
}

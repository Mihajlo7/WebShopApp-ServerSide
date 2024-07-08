using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using GenericEntity;
using Microsoft.EntityFrameworkCore;

namespace GenericInfrastructure
{
    public interface IUnitOfWork : IDisposable 
    {
        Task<int> CommitChanges();
        IRepository<TEntity> GetRepository<TEntity>() where TEntity: IEntity;
    }
}

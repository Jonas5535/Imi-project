using Imi.Project.Api.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Infrastructure.Repositories
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAll();
        Task<IEnumerable<T>> ListAllAsync();
        Task<T> GetByIdAsync(Guid id);
        Task<T> AddAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<T> DeleteAsync(Guid id);
        Task<T> DeleteAsync(T entity);
    }
}

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imi.Project.Blazor.Core.CRUD.Services
{
    public interface ICRUDService<T, D, E>
    {
        Task<IEnumerable<T>> ListAllAsync();
        Task<D> GetByIdAsync(Guid id);
        Task AddAsync(E item);
        Task UpdateAsync(E item);
        Task DeleteAsync(Guid id);
    }
}

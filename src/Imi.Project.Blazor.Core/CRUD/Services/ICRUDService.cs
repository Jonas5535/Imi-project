using System;
using System.Threading.Tasks;

namespace Imi.Project.Blazor.Core.CRUD.Services
{
    public interface ICRUDService<T, K>
    {
        Task<T[]> ListAllAsync();
        Task<K> GetByIdAsync(Guid id);
        Task AddAsync(K item);
        Task UpdateAsync(K item);
        Task DeleteAsync(Guid id);
    }
}

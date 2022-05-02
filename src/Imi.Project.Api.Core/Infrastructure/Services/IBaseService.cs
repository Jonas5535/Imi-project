using Imi.Project.Api.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Infrastructure.Services
{
    public interface IBaseService<T, D, R> where T : BaseDto where D : BaseDto where R : BaseDto
    {
        Task<IEnumerable<T>> ListAllAsync();
        Task<D> GetByIdAsync(Guid id);
        Task<T> AddAsync(R requestDto);
        Task<D> UpdateAsync(R requestDto);
        Task<BaseDto> DeleteAsync(Guid id);
    }
}

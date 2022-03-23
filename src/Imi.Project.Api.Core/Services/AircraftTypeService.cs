using Imi.Project.Api.Core.Dtos.AircraftType;
using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Core.Infrastructure.Repositories;
using Imi.Project.Api.Core.Infrastructure.Services;
using Imi.Project.Api.Core.Mapping;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Services
{
    public class AircraftTypeService : IAircraftTypeService
    {
        private readonly IAircraftTypeRepository _aircraftTypeRepository;

        public AircraftTypeService(IAircraftTypeRepository aircraftTypeRepository)
        {
            _aircraftTypeRepository = aircraftTypeRepository;
        }

        public Task<AircraftTypeListResponseDto> AddAsync(AircraftTypeRequestDto requestDto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<AircraftTypeDetailResponseDto> GetByIdAsync(Guid id)
        {
            AircraftType result = await _aircraftTypeRepository.GetByIdAsync(id);
            AircraftTypeDetailResponseDto dto = result.MapToDetailDto();
            return dto;
        }

        public async Task<IEnumerable<AircraftTypeListResponseDto>> ListAllAsync()
        {
            IEnumerable<AircraftType> result = await _aircraftTypeRepository.ListAllAsync();
            IEnumerable<AircraftTypeListResponseDto> dtos = result.MapToListDto();
            return dtos;
        }

        public Task<AircraftTypeDetailResponseDto> UpdateAsync(AircraftTypeRequestDto requestDto)
        {
            throw new NotImplementedException();
        }
    }
}

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

        public async Task<AircraftTypeListResponseDto> AddAsync(AircraftTypeRequestDto requestDto)
        {
            AircraftType aircraftTypeEntity = requestDto.MapToEntity();

            //TODO Add Errorhandling

            await _aircraftTypeRepository.AddAsync(aircraftTypeEntity);
            AircraftTypeListResponseDto dto = aircraftTypeEntity.MapToListDtoSingle();
            return dto;
        }

        public async Task DeleteAsync(Guid id)
        {
            //TODO Check if id exists
            await _aircraftTypeRepository.DeleteAsync(id);
        }

        public async Task<AircraftTypeDetailResponseDto> GetByIdAsync(Guid id)
        {
            //TODO Check if id exists
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

        public async Task<AircraftTypeDetailResponseDto> UpdateAsync(AircraftTypeRequestDto requestDto)
        {
            AircraftType aircraftTypeEntity = requestDto.MapToEntity();

            //TODO Add errorhandling

            await _aircraftTypeRepository.UpdateAsync(aircraftTypeEntity);
            AircraftTypeDetailResponseDto dto = aircraftTypeEntity.MapToDetailDto();
            return dto;
        }
    }
}

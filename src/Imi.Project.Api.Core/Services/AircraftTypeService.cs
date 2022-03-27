using Imi.Project.Api.Core.Dtos;
using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Core.Infrastructure.Repositories;
using Imi.Project.Api.Core.Infrastructure.Services;
using Imi.Project.Api.Core.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Services
{
    public class AircraftTypeService : IAircraftTypeService
    {
        private readonly IAircraftTypeRepository _aircraftTypeRepository;
        private readonly IAircraftRepository _aircraftRepository;

        public AircraftTypeService(IAircraftTypeRepository aircraftTypeRepository, IAircraftRepository aircraftRepository)
        {
            _aircraftTypeRepository = aircraftTypeRepository;
            _aircraftRepository = aircraftRepository;
        }

        public async Task<AircraftTypeListResponseDto> AddAsync(AircraftTypeRequestDto requestDto)
        {
            AircraftTypeListResponseDto dto = new AircraftTypeListResponseDto();
            IQueryable<AircraftType> types = _aircraftTypeRepository.GetAll();

            if (requestDto.Id != new Guid() && types.Any(a => a.Id.Equals(requestDto.Id)))
            {
                dto.AddBadRequest($"Aircrafttype with id {requestDto.Id} already exists");
                return dto;
            }

            if (types.Any(a => a.ICAOCode.Equals(requestDto.ICAOCode)))
            {
                dto.AddBadRequest($"Aircrafttype with ICAO code {requestDto.ICAOCode} already exists");
                return dto;
            }

            if (requestDto.FirstFlight > DateTime.Today)
            {
                dto.AddBadRequest($"The date of the first flight cannot be later than {DateTime.Today.ToShortDateString()}");
                return dto;
            }

            AircraftType aircraftTypeEntity = requestDto.MapToEntity();
            aircraftTypeEntity.AddedOn = DateTime.Now;
            aircraftTypeEntity.ModifiedOn = DateTime.Now;
            await _aircraftTypeRepository.AddAsync(aircraftTypeEntity);

            dto = aircraftTypeEntity.MapToListDtoSingle();
            return dto;
        }

        public async Task<BaseDto> DeleteAsync(Guid id)
        {
            BaseDto dto = new BaseDto();

            if (!_aircraftTypeRepository.GetAll().Any(a => a.Id.Equals(id)))
            {
                dto.AddNotFound($"No aircraftType with id {id} exists");
                return dto;
            }

            if (_aircraftRepository.GetAll().Any(a => a.AircraftTypeId.Equals(id)))
            {
                dto.AddBadRequest("Cannot delete this aircrafttype because there are still aircraft coupled to it. Please uncouple all coupled aircrafts first.");
                return dto;
            }
            
            await _aircraftTypeRepository.DeleteAsync(id);
            return dto;
        }

        public async Task<AircraftTypeDetailResponseDto> GetByIdAsync(Guid id)
        {
            AircraftTypeDetailResponseDto dto = new AircraftTypeDetailResponseDto();

            if (!_aircraftTypeRepository.GetAll().Any(a => a.Id.Equals(id)))
            {
                dto.AddNotFound($"No aircrafttypes with id {id} exist");
                return dto;
            }

            AircraftType result = await _aircraftTypeRepository.GetByIdAsync(id);
            dto = result.MapToDetailDto();
            return dto;
        }

        public async Task<IEnumerable<AircraftTypeListResponseDto>> ListAllAsync()
        {
            IEnumerable<AircraftType> result = await _aircraftTypeRepository.ListAllAsync();

            IEnumerable<AircraftTypeListResponseDto> dtos = result.OrderByDescending(a => a.ModifiedOn).MapToListDto();
            return dtos;
        }

        public async Task<AircraftTypeDetailResponseDto> UpdateAsync(AircraftTypeRequestDto requestDto)
        {
            AircraftTypeDetailResponseDto dto = new AircraftTypeDetailResponseDto();
            IQueryable<AircraftType> types = _aircraftTypeRepository.GetAll();

            if (!types.Any(a => a.Id.Equals(requestDto.Id)))
            {
                dto.AddNotFound($"No aircrafttype with id {requestDto.Id} exists");
                return dto;
            }

            // Checking if the user isn't changing the icao code to something that already exist,
            // while making sure it doesn't throw an error because the user didn't change the icao code
            AircraftType currentType = types.FirstOrDefault(a => a.Id.Equals(requestDto.Id));
            if (types.Any(a => a.ICAOCode.Equals(requestDto.ICAOCode)) && requestDto.ICAOCode != currentType.ICAOCode)
            {
                dto.AddConflict($"Record with ICAO code {requestDto.ICAOCode} already exists");
                return dto;
            }

            if (requestDto.FirstFlight > DateTime.Today)
            {
                dto.AddBadRequest($"The date of the first flight cannot be later than {DateTime.Today.ToShortDateString()}");
                return dto;
            }

            AircraftType aircraftTypeEntity = requestDto.MapToEntity();
            aircraftTypeEntity.AddedOn = currentType.AddedOn;
            aircraftTypeEntity.ModifiedOn = DateTime.Now;
            await _aircraftTypeRepository.UpdateAsync(aircraftTypeEntity);

            dto = aircraftTypeEntity.MapToDetailDto();
            return dto;
        }
    }
}

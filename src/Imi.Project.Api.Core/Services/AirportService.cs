﻿using Imi.Project.Api.Core.Dtos.Airport;
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
    public class AirportService : IAirportService
    {

        private readonly IAirportRepository _airportRepository;

        public AirportService(IAirportRepository airportRepository)
        {
            _airportRepository = airportRepository;
        }

        public async Task<AirportListResponseDto> AddAsync(AirportRequestDto requestDto)
        {
            Airport airportEntity = requestDto.MapToEntity();

            //TODO Add ErrorHandling

            airportEntity.AddedOn = DateTime.Now;
            airportEntity.ModifiedOn = DateTime.Now;
            await _airportRepository.AddAsync(airportEntity);

            AirportListResponseDto dto = airportEntity.MapToListDtoSingle();
            return dto;
        }

        public async Task DeleteAsync(Guid id)
        {
            //TODO Add check for existing id
            await _airportRepository.DeleteAsync(id);
        }

        public async Task<AirportDetailResponseDto> GetByIdAsync(Guid id)
        {
            AirportDetailResponseDto dto = new AirportDetailResponseDto();
            var airports = _airportRepository.GetAll().Where(a => a.Id == id).SingleOrDefault();

            if (airports == null)
            {
                dto.AddNotFound($"No airports found with id {id}");
                return dto;
            }

            Airport result = await _airportRepository.GetByIdAsync(id);
            dto = result.MapToDetailDto();
            return dto;
        }

        public async Task<IEnumerable<AirportListResponseDto>> ListAllAsync()
        {
            IEnumerable<Airport> result = await _airportRepository.ListAllAsync();
            IEnumerable<AirportListResponseDto> dtos = result.MapToListDto();
            return dtos;
        }

        public async Task<AirportDetailResponseDto> UpdateAsync(AirportRequestDto requestDto)
        {
            Airport airportEntity = requestDto.MapToEntity();

            //TODO Add errorhandling

            airportEntity.ModifiedOn = DateTime.Now;
            await _airportRepository.UpdateAsync(airportEntity);

            AirportDetailResponseDto dto = airportEntity.MapToDetailDto();
            return dto;
        }
    }
}

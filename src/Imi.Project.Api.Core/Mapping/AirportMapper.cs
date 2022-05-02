using Imi.Project.Api.Core.Dtos;
using Imi.Project.Api.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Imi.Project.Api.Core.Mapping
{
    public static class AirportMapper
    {
        public static IEnumerable<AirportListResponseDto> MapToListDto(this IEnumerable<Airport> airportEntities)
        {
            return airportEntities.Select(ae => ae.MapToListDtoSingle());
        }

        public static AirportListResponseDto MapToListDtoSingle(this Airport airportEntity)
        {
            AirportListResponseDto dto = new AirportListResponseDto
            {
                Id = airportEntity.Id,
                Name = airportEntity.Name,
                IATACode = airportEntity.IATACode,
                ICAOCode = airportEntity.ICAOCode,
                AddedOn = airportEntity.AddedOn,
                ModifiedOn = airportEntity.ModifiedOn,
            };
            return dto;
        }

        public static AirportDetailResponseDto MapToDetailDto(this Airport airportEntity)
        {
            AirportDetailResponseDto dto = new AirportDetailResponseDto
            {
                Id = airportEntity.Id,
                Name = airportEntity.Name,
                IATACode = airportEntity.IATACode,
                ICAOCode = airportEntity.ICAOCode,
                ElevationAMSL = airportEntity.ElevationAMSL,
                RunwayAmount = airportEntity.RunwayAmount,
                TerminalAmount = airportEntity.TerminalAmount,
                Country = airportEntity.Country,
                City = airportEntity.City,
            };
            return dto;
        }

        public static Airport MapToEntity(this AirportRequestDto requestDto)
        {
            if (requestDto.Id != Guid.Empty)
            {
                Airport airportToBeUpdated = new Airport
                {
                    Id = requestDto.Id,
                    Name = requestDto.Name,
                    IATACode = requestDto.IATACode?.ToUpper(),
                    ICAOCode = requestDto.ICAOCode?.ToUpper(),
                    ElevationAMSL = requestDto.ElevationAMSL,
                    RunwayAmount = requestDto.RunwayAmount,
                    TerminalAmount = requestDto.TerminalAmount,
                    Country = requestDto.Country,
                    City = requestDto.City,
                };
                return airportToBeUpdated;
            }

            Airport airportEntity = new Airport
            {
                Name = requestDto.Name,
                IATACode = requestDto.IATACode?.ToUpper(),
                ICAOCode = requestDto.ICAOCode?.ToUpper(),
                ElevationAMSL = requestDto.ElevationAMSL,
                RunwayAmount = requestDto.RunwayAmount,
                TerminalAmount = requestDto.TerminalAmount,
                Country = requestDto.Country,
                City = requestDto.City,
            };
            return airportEntity;
        }
    }
}

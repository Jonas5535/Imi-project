using Imi.Project.Api.Core.Dtos.Airport;
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
            IEnumerable<AirportListResponseDto> dtos = airportEntities.Select(ae =>
                new AirportListResponseDto
                {
                    Id = ae.Id,
                    Name = ae.Name,
                    IATACode = ae.IATACode,
                    ICAOCode = ae.ICAOCode,
                    AddedOn = ae.AddedOn,
                    ModifiedOn = ae.ModifiedOn,
                });
            return dtos;
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
                    IATACode = requestDto.IATACode,
                    ICAOCode = requestDto.ICAOCode,
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
                IATACode = requestDto.IATACode,
                ICAOCode = requestDto.ICAOCode,
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

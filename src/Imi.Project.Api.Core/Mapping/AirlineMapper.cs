using Imi.Project.Api.Core.Dtos.Airline;
using Imi.Project.Api.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Imi.Project.Api.Core.Mapping
{
    public static class AirlineMapper
    {
        public static IEnumerable<AirlineListResponseDto> MapToListDto(this IEnumerable<Airline> airlineEntities)
        {
            IEnumerable<AirlineListResponseDto> dtos = airlineEntities.Select(ae =>
            new AirlineListResponseDto
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

        public static AirlineDetailResponseDto MapToDetailDto(this Airline airlineEntity)
        {
            return new AirlineDetailResponseDto
            {
                Id = airlineEntity.Id,
                Name = airlineEntity.Name,
                IATACode = airlineEntity.IATACode,
                ICAOCode = airlineEntity.ICAOCode,
                MainAirport = airlineEntity.MainAirport,
                HeadQuarter = airlineEntity.HeadQuarter,
                FleetSize = airlineEntity.FleetSize,
            };
        }

        public static Airline MapToEntity(this AirlineRequestDto requestDto)
        {
            if (requestDto.Id != Guid.Empty)
            {
                Airline airlineToBeUpdated = new Airline
                {
                    Id = requestDto.Id,
                    Name = requestDto.Name,
                    IATACode = requestDto.IATACode?.ToUpper(),
                    ICAOCode = requestDto.ICAOCode?.ToUpper(),
                    MainAirport = requestDto.MainAirport,
                    HeadQuarter = requestDto.HeadQuarter,
                    FleetSize = requestDto.FleetSize
                };
                return airlineToBeUpdated;
            }

            Airline airlineEntity = new Airline
            {
                Name = requestDto.Name,
                IATACode = requestDto.IATACode?.ToUpper(),
                ICAOCode = requestDto.ICAOCode?.ToUpper(),
                MainAirport = requestDto.MainAirport,
                HeadQuarter = requestDto.HeadQuarter,
                FleetSize = requestDto.FleetSize,
            };

            return airlineEntity;
        }
    }
}

using Imi.Project.Api.Core.Dtos;
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
            return airlineEntities.Select(ae => ae.MapToListDtoSingle());
        }

        public static AirlineListResponseDto MapToListDtoSingle(this Airline airlineEntity)
        {
            AirlineListResponseDto dto = new AirlineListResponseDto
            {
                Id = airlineEntity.Id,
                Name = airlineEntity.Name,
                IATACode = airlineEntity.IATACode,
                ICAOCode = airlineEntity.ICAOCode,
                AddedOn = airlineEntity.AddedOn,
                ModifiedOn = airlineEntity.ModifiedOn,
            };
            return dto;
        }

        public static AirlineDetailResponseDto MapToDetailDto(this Airline airlineEntity)
        {
            AirlineDetailResponseDto dto = new AirlineDetailResponseDto
            {
                Id = airlineEntity.Id,
                Name = airlineEntity.Name,
                IATACode = airlineEntity.IATACode,
                ICAOCode = airlineEntity.ICAOCode,
                MainAirport = airlineEntity.MainAirport,
                HeadQuarter = airlineEntity.HeadQuarter,
                FleetSize = airlineEntity.FleetSize,
            };
            return dto;
        }

        public static Airline MapToEntity(this AirlineRequestDto requestDto)
        {
            if (requestDto.Id != Guid.Empty)
            {
                Airline airlineToBeUpdated = new Airline
                {
                    Id = requestDto.Id,
                    AddedOn = requestDto.AddedOn,
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

using Imi.Project.Api.Core.Dtos;
using Imi.Project.Api.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Imi.Project.Api.Core.Mapping
{
    public static class AircraftTypeMapper
    {
        public static IEnumerable<AircraftTypeListResponseDto> MapToListDto(this IEnumerable<AircraftType> aircraftTypeEntities)
        {
            return aircraftTypeEntities.Select(ae => ae.MapToListDtoSingle());
        }

        public static AircraftTypeListResponseDto MapToListDtoSingle(this AircraftType aircraftTypeEntity)
        {
            AircraftTypeListResponseDto dto = new AircraftTypeListResponseDto
            {
                Id = aircraftTypeEntity.Id,
                Brand = aircraftTypeEntity.Brand,
                Type = aircraftTypeEntity.Type,
                ICAOCode = aircraftTypeEntity.ICAOCode,
                AddedOn = aircraftTypeEntity.AddedOn,
                ModifiedOn = aircraftTypeEntity.ModifiedOn
            };
            return dto;
        }

        public static AircraftTypeDetailResponseDto MapToDetailDto(this AircraftType aircraftTypeEntity)
        {
            AircraftTypeDetailResponseDto dto = new AircraftTypeDetailResponseDto
            {
                Id = aircraftTypeEntity.Id,
                Brand = aircraftTypeEntity.Brand,
                Type = aircraftTypeEntity.Type,
                ICAOCode = aircraftTypeEntity.ICAOCode,
                EmptyWeight = aircraftTypeEntity.EmptyWeight,
                FirstFlight = aircraftTypeEntity.FirstFlight,
                Height = aircraftTypeEntity.Height,
                Length = aircraftTypeEntity.Length,
                WingSpan = aircraftTypeEntity.WingSpan,
            };
            return dto;
        }

        public static AircraftType MapToEntity(this AircraftTypeRequestDto requestDto)
        {
            if (requestDto.Id != Guid.Empty)
            {
                AircraftType aircraftTypeToBeUpdated = new AircraftType
                {
                    Id = requestDto.Id,
                    AddedOn = requestDto.AddedOn,
                    Brand = requestDto.Brand,
                    Type = requestDto.Type?.ToUpper(),
                    ICAOCode = requestDto.ICAOCode?.ToUpper(),
                    EmptyWeight = requestDto.EmptyWeight,
                    FirstFlight = requestDto.FirstFlight,
                    Height = requestDto.Height,
                    Length = requestDto.Length,
                    WingSpan = requestDto.WingSpan,
                };
                return aircraftTypeToBeUpdated;
            }

            AircraftType aircraftTypeEntity = new AircraftType
            {
                Brand = requestDto.Brand,
                Type = requestDto.Type?.ToUpper(),
                ICAOCode = requestDto.ICAOCode?.ToUpper(),
                EmptyWeight = requestDto.EmptyWeight,
                FirstFlight = requestDto.FirstFlight,
                Height = requestDto.Height,
                Length = requestDto.Length,
                WingSpan = requestDto.WingSpan,
            };
            return aircraftTypeEntity;
        }
    }
}

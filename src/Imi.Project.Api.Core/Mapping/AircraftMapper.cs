using Imi.Project.Api.Core.Dtos;
using Imi.Project.Api.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Imi.Project.Api.Core.Mapping
{
    public static class AircraftMapper
    {
        public static IEnumerable<AircraftListResponseDto> MapToListDto(this IEnumerable<Aircraft> aircraftEntities)
        {
            return aircraftEntities.Select(ae => ae.MaptoListDtoSingle());
        }

        public static AircraftListResponseDto MaptoListDtoSingle(this Aircraft aircraftEntity)
        {
            // Map all airport in SpottedAtAirports prop to AirportListResponseDto
            // and add them to a list of AirportListResponseDtos so it can be given to
            // the Airports prop of AircraftListResponseDto
            List<AirportListResponseDto> airports = new();

            foreach (var airport in aircraftEntity.SpottedAtAirports)
            {
                var a = airport.Airport?.MapToListDtoSingle();
                airports.Add(a);
            }

            AircraftListResponseDto dto = new AircraftListResponseDto
            {
                Id = aircraftEntity.Id,
                Registration = aircraftEntity.Registration,
                HasSpecialLivery = aircraftEntity.HasSpecialLivery,
                Image = aircraftEntity.Image,
                AircraftType = aircraftEntity.AircraftType?.MapToListDtoSingle(),
                Airline = aircraftEntity.Airline?.MapToListDtoSingle(),
                Airports = airports,
            };
            return dto;
        }

        public static AircraftDetailResponseDto MapToDetailDto(this Aircraft aircraftEntity)
        {
            // Map all airport in SpottedAtAirports prop to AirportListResponseDto
            // and add them to a list of AirportListResponseDtos so it can be given to
            // the Airports prop of AircraftListResponseDto
            List<AirportListResponseDto> airports = new();

            foreach (var airport in aircraftEntity.SpottedAtAirports)
            {
                var a = airport.Airport.MapToListDtoSingle();
                airports.Add(a);
            }

            AircraftDetailResponseDto dto = new AircraftDetailResponseDto
            {
                Id = aircraftEntity.Id,
                Registration = aircraftEntity.Registration,
                HasSpecialLivery = aircraftEntity.HasSpecialLivery,
                FirstSeen = aircraftEntity.FirstSeen,
                LastSeen = aircraftEntity.LastSeen,
                Image = aircraftEntity.Image,
                Longitude = aircraftEntity.Longitude,
                Latitude = aircraftEntity.Latitude,
                AircraftType = aircraftEntity.AircraftType?.MapToListDtoSingle(),
                Airline = aircraftEntity.Airline?.MapToListDtoSingle(),
                Airports = airports,
            };
            return dto;
        }

        public static Aircraft MapToEntity(this AircraftRequestDto requestDto, Aircraft entity)
        {
            //Bind AirportId and AircraftId from requestDto together in an AircraftAtAirport object
            //so it can be mapped to the SpottedAtAirports prop from aircraft entity.
            List<AircraftAtAirport> airports = new();

            foreach (var airportId in requestDto.AirportIds)
            {
                var p = new AircraftAtAirport { AirportId = airportId, AircraftId = requestDto.Id };

                airports.Add(p);
            }

            // Checking if requestDto contains a new or an existing aircraft
            if (entity != null)
            {
                entity.Id = requestDto.Id;
                entity.Registration = requestDto.Registration?.ToUpper();
                entity.HasSpecialLivery = requestDto.HasSpecialLivery;
                entity.FirstSeen = requestDto.FirstSeen.Date;
                entity.LastSeen = requestDto.LastSeen.Date;
                //Latitude = requestDto.Latitude,   //Not yet in use
                //Longitude = requestDto.Longitude, //Not yet in use
                entity.AirlineId = requestDto.AirlineId;
                entity.AircraftTypeId = requestDto.AircraftTypeId;
                entity.SpottedAtAirports = airports;

                return entity;
            }

            Aircraft aircraftEntity = new Aircraft
            {
                Registration = requestDto.Registration?.ToUpper(),
                HasSpecialLivery = requestDto.HasSpecialLivery,
                FirstSeen = requestDto.FirstSeen.Date,
                LastSeen = requestDto.LastSeen.Date,
                //Latitude = requestDto.Latitude,   //Not yet in use
                //Longitude = requestDto.Longitude, //Not yet in use
                AirlineId = requestDto.AirlineId,
                AircraftTypeId = requestDto.AircraftTypeId,
                SpottedAtAirports = airports
            };
            return aircraftEntity;
        }
    }
}

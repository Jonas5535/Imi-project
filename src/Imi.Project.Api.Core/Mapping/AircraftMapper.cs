using Imi.Project.Api.Core.Dtos.Aircraft;
using Imi.Project.Api.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Mapping
{
    public static class AircraftMapper
    {
        public static Aircraft MapToEntity(this AircraftRequestDto requestDto)
        {
            //Bind AirportId and AircraftId from requestDto together in an AircraftAtAirport object
            //so it can be mapped to the SpottedAtAirports prop from aircraft entity.
            List<AircraftAtAirport> airports = new List<AircraftAtAirport>();

            foreach (var airportId in requestDto.AirportIds)
            {
                var p = new AircraftAtAirport { AirportId = airportId, AircraftId = requestDto.Id };

                airports.Add(p);
            }

            // Checking if requestDto contains a new or an existing aircraft
            if (requestDto.Id != Guid.Empty)
            {
                Aircraft aircraftToBeUpdated = new Aircraft
                {
                    Id = requestDto.Id,
                    Registration = requestDto.Registration.ToUpper(),
                    HasSpecialLivery = requestDto.HasSpecialLivery,
                    FirstSeen = requestDto.FirstSeen.Date,
                    LastSeen = requestDto.LastSeen.Date,
                    Image = requestDto.Image,
                    Latitude = requestDto.Latitude,
                    Longitude = requestDto.Longitude,
                    AirlineId = requestDto.AirlineId,
                    AircraftTypeId = requestDto.AircraftTypeId,
                    SpottedAtAirports = airports
                };
                return aircraftToBeUpdated;
            }

            Aircraft aircraftEntity = new Aircraft
            {
                Registration = requestDto.Registration.ToUpper(),
                HasSpecialLivery = requestDto.HasSpecialLivery,
                FirstSeen = requestDto.FirstSeen.Date,
                LastSeen = requestDto.LastSeen.Date,
                Image = requestDto.Image,
                Latitude = requestDto.Latitude,
                Longitude = requestDto.Longitude,
                AirlineId = requestDto.AirlineId,
                AircraftTypeId = requestDto.AircraftTypeId,
                SpottedAtAirports = airports
            };
            return aircraftEntity;
        }
    }
}

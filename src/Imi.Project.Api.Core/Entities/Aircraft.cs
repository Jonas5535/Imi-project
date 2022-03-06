using System;
using System.Collections.Generic;

namespace Imi.Project.Api.Core.Entities
{
    public class Aircraft : BaseEntity
    {
        public string Registration { get; set; }
        public bool HasSpecialLivery { get; set; }
        public DateTime FirstSeen { get; set; }
        public DateTime LastSeen { get; set; }
        public string Image { get; set; }

        //This will be used to store gps location
        public double Longitude { get; set; }
        public double Latitude { get; set; }

        // Unshadowed property for AircraftType
        public Guid AircraftTypeId { get; set; }
        public AircraftType AircraftType { get; set; }

        // Unshadowed property for Airline
        public Guid AirlineId { get; set; }
        public Airline Airline { get; set; }

        // This is a collection of airports at which the aircraft has been spotted
        public ICollection<AircraftAtAirport> SpottedAtAirports { get; set; }
    }
}
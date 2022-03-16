using Imi.Project.Api.Core.Dtos.AircraftType;
using Imi.Project.Api.Core.Dtos.Airline;
using Imi.Project.Api.Core.Dtos.Airport;
using System;
using System.Collections.Generic;

namespace Imi.Project.Api.Core.Dtos.Aircraft
{
    public class AircraftDetailResponseDto
    {
        public string Registration { get; set; }
        public bool HasSpecialLivery { get; set; }
        public DateTime FirstSeen { get; set; }
        public DateTime LastSeen { get; set; }
        public string Image { get; set; }
        public double? Longitude { get; set; }
        public double? Latitude { get; set; }
        public AircraftTypeListResponseDto AircraftType { get; set; }
        public AirlineListResponseDto Airline { get; set; }
        public ICollection<AirportListResponseDto> Airports { get; set; }
    }
}

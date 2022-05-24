using System;
using System.Collections.Generic;

namespace Imi.Project.Api.Core.Dtos
{
    public class AircraftDetailResponseDto : BaseDto
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

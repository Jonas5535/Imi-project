using System;
using System.Collections.Generic;

namespace Imi.Project.Api.Core.Dtos
{
    public class AircraftListResponseDto : BaseDto
    {
        public string Registration { get; set; }
        public bool HasSpecialLivery { get; set; }
        public string Image { get; set; }
        public AircraftTypeListResponseDto AircraftType { get; set; }
        public AirlineListResponseDto Airline { get; set; }
        public ICollection<AirportListResponseDto> Airports { get; set; }
    }
}

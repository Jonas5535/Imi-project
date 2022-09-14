using System;
using System.Collections.Generic;

namespace Imi.Project.Wpf.Core.ApiModels
{
    public class ApiAircraftDetailResponse
    {
        public Guid Id { get; set; }
        public string Registration { get; set; }
        public bool HasSpecialLivery { get; set; }
        public DateTime FirstSeen { get; set; }
        public DateTime LastSeen { get; set; }
        public object Image { get; set; }
        public double? Longitude { get; set; }
        public double? Latitude { get; set; }
        public ApiAircraftTypeResponse AircraftType { get; set; }
        public ApiAirlineResponse Airline { get; set; }
        public ICollection<ApiAirportResponse> Airports { get; set; }
    }
}

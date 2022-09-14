using System.Collections.Generic;

namespace Imi.Project.Wpf.Core.ApiModels
{
    public class ApiAircraftListResponse
    {
        public string Id { get; set; }
        public string Registration { get; set; }
        public bool HasSpecialLivery { get; set; }
        public object Image { get; set; }
        public ApiAircraftTypeResponse AircraftType { get; set; }
        public ApiAirlineResponse Airline { get; set; }
        public ICollection<ApiAirportResponse> Airports { get; set; }

        public override string ToString()
        {
            return $"{Registration} - {AircraftType.IcaoCode} - {Airline.Name}";
        }
    }
}

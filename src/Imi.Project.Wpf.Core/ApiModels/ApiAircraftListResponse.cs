using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Imi.Project.Wpf.Core.ApiModels
{
    public class ApiAircraftListResponse
    {
        [JsonPropertyName("registration")]
        public string Registration { get; set; }

        [JsonPropertyName("hasSpecialLivery")]
        public bool HasSpecialLivery { get; set; }

        [JsonPropertyName("image")]
        public object Image { get; set; }

        [JsonPropertyName("aircraftType")]
        public ApiAircraftTypeResponse AircraftType { get; set; }

        [JsonPropertyName("airline")]
        public ApiAirlineResponse Airline { get; set; }

        [JsonPropertyName("airports")]
        public List<ApiAirportResponse> Airports { get; set; }

        [JsonPropertyName("addedOn")]
        public DateTime AddedOn { get; set; }

        [JsonPropertyName("modifiedOn")]
        public DateTime ModifiedOn { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        public override string ToString()
        {
            return $"{Registration} - {AircraftType.IcaoCode} - {Airline.Name}";
        }
    }
}

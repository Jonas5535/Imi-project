using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Imi.Project.Wpf.Core.ApiModels
{
    public class ApiAircraftDetailResponse
    {
        [JsonPropertyName("registration")]
        public string Registration { get; set; }

        [JsonPropertyName("hasSpecialLivery")]
        public bool HasSpecialLivery { get; set; }

        [JsonPropertyName("firstSeen")]
        public DateTime FirstSeen { get; set; }

        [JsonPropertyName("lastSeen")]
        public DateTime LastSeen { get; set; }

        [JsonPropertyName("image")]
        public object Image { get; set; }

        [JsonPropertyName("longitude")]
        public object Longitude { get; set; }

        [JsonPropertyName("latitude")]
        public object Latitude { get; set; }

        [JsonPropertyName("aircraftType")]
        public ApiAircraftTypeResponse AircraftType { get; set; }

        [JsonPropertyName("airline")]
        public ApiAirlineResponse Airline { get; set; }

        [JsonPropertyName("airports")]
        public List<ApiAirportResponse> Airports { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}
}

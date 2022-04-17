using System;
using System.Text.Json.Serialization;

namespace Imi.Project.Wpf.Core.ApiModels
{
    public class ApiAirportResponse
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("iataCode")]
        public string IataCode { get; set; }

        [JsonPropertyName("icaoCode")]
        public string IcaoCode { get; set; }

        [JsonPropertyName("addedOn")]
        public DateTime AddedOn { get; set; }

        [JsonPropertyName("modifiedOn")]
        public DateTime ModifiedOn { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        public override string ToString()
        {
            return Name.ToString();
        }
    }
}

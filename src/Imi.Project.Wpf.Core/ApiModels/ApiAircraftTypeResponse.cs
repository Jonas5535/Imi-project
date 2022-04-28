using System;
using System.Text.Json.Serialization;

namespace Imi.Project.Wpf.Core.ApiModels
{
    public class ApiAircraftTypeResponse
    {
        [JsonPropertyName("brand")]
        public string Brand { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

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
            return Type.ToString();
        }
    }
}

namespace Imi.Project.Api.Core.Dtos
{
    public class AirlineDetailResponseDto : BaseDto
    {
        public string Name { get; set; }
        public string IATACode { get; set; }
        public string ICAOCode { get; set; }
        public string MainAirport { get; set; }
        public string HeadQuarter { get; set; }
        public int? FleetSize { get; set; }
    }
}

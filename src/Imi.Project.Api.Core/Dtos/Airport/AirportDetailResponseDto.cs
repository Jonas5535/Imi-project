namespace Imi.Project.Api.Core.Dtos.Airport
{
    public class AirportDetailResponseDto : BaseDto
    {
        public string Name { get; set; }
        public string IATACode { get; set; }
        public string ICAOCode { get; set; }
        public int? ElevationAMSL { get; set; }
        public int? RunwayAmount { get; set; }
        public int? TerminalAmount { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
    }
}

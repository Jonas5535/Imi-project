namespace Imi.Project.Api.Core.Dtos.Airport
{
    public class AirportListResponseDto : BaseDto
    {
        public string Name { get; set; }
        public string IATACode { get; set; }
        public string ICAOCode { get; set; }
    }
}

using System;

namespace Imi.Project.Api.Core.Dtos
{
    public class AircraftTypeDetailResponseDto : BaseDto
    {
        public string Brand { get; set; }
        public string Type { get; set; }
        public string ICAOCode { get; set; }
        public DateTime? FirstFlight { get; set; }
        public double? Length { get; set; }
        public double? WingSpan { get; set; }
        public double? Height { get; set; }
        public int? EmptyWeight { get; set; }
    }
}

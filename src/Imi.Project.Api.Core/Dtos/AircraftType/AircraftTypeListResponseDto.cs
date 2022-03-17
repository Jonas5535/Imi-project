using System;

namespace Imi.Project.Api.Core.Dtos.AircraftType
{
    public class AircraftTypeListResponseDto : BaseDto
    {
        public string Brand { get; set; }
        public string Type { get; set; }
        public string ICAOCode { get; set; }
        public DateTime? AddedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}

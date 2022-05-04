using System;

namespace Imi.Project.Api.Core.Dtos
{
    public class AircraftTypeListResponseDto : BaseDto
    {
        public string Brand { get; set; }
        public string Type { get; set; }
        public string ICAOCode { get; set; }
    }
}

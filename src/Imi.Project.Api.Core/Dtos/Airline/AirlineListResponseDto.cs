using System;

namespace Imi.Project.Api.Core.Dtos
{
    public class AirlineListResponseDto : BaseDto
    {
        public string Name { get; set; }
        public string IATACode { get; set; }
        public string ICAOCode { get; set; }
    }
}

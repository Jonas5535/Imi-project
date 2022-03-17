using System;

namespace Imi.Project.Api.Core.Dtos.Airline
{
    public class AirlineListResponseDto : BaseDto
    {
        public string Name { get; set; }
        public string IATACode { get; set; }
        public string ICAOCode { get; set; }
        public DateTime? AddedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}

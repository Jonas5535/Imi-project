using System;
using System.Collections.Generic;

namespace Imi.Project.Api.Core.Entities
{
    public class AircraftType : BaseEntity
    {
        public string Brand { get; set; }
        public string Type { get; set; }
        public string ICAOCode { get; set; }
        public DateTime? FirstFlight { get; set; }
        public double? Length { get; set; }
        public double? WingSpan { get; set; }
        public double? Height { get; set; }
        public int? EmptyWeight { get; set; }

        //Navigation prop for aircraft
        public ICollection<Aircraft> Aircrafts { get; set; }
    }
}
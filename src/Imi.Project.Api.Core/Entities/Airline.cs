using System.Collections.Generic;

namespace Imi.Project.Api.Core.Entities
{
    public class Airline : BaseEntity
    {
        public string Name { get; set; }
        public string IATACode { get; set; }
        public string ICAOCode { get; set; }
        public string MainAirport { get; set; }
        public string HeadQuarter { get; set; }
        public int? Fleetsize { get; set; }

        //Navigation prop for aircraft
        public ICollection<Aircraft> Aircrafts { get; set; }
    }
}
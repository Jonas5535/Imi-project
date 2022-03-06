using System.Collections.Generic;

namespace Imi.Project.Api.Core.Entities
{
    public class Airport : BaseEntity
    {
        public string Name { get; set; }
        public string IATACode { get; set; }
        public string ICAOCode { get; set; }
        public int? ElevationAMSL { get; set; }
        public int? RunwayAmount { get; set; }
        public int? TerminalAmount { get; set; }
        public string Country { get; set; }
        public string City { get; set; }

        //This is a collection of aircraft that have been spotted at this airport
        public ICollection<AircraftAtAirport> AircraftsAtAirport { get; set; }
    }
}

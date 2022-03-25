using System;

namespace Imi.Project.Api.Core.Entities
{
    public class AircraftAtAirport
    {
        //Unshadowed foreign keys for relationship seeding
        public Guid AircraftId { get; set; }
        public Guid AirportId { get; set; }

        //Used to couple aircraft to airport and viceversa
        public Aircraft Aircraft { get; set; }
        public Airport Airport { get; set; }
    }
}
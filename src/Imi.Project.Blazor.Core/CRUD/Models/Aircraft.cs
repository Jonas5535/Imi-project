using System;
using System.Collections.Generic;

namespace Imi.Project.Blazor.Core.CRUD.Models
{
    public class Aircraft
    {
        public Guid Id { get; set; }
        public string Registration { get; set; }
        public bool HasSpecialLivery { get; set; }
        public DateTime FirstSeen { get; set; }
        public DateTime LastSeen { get; set; }
        public string Image { get; set; }
        public Guid AircraftTypeId { get; set; }
        public AircraftType AircraftTypes { get; set; }
        public Guid AirlineId { get; set; }
        public Airline Airlines { get; set; }
        public ICollection<Guid> AirportIds { get; set; }
        public Airport Airports { get; set; }
    }
}

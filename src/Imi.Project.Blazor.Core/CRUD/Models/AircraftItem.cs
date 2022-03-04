using System;
using System.Collections.Generic;

namespace Imi.Project.Blazor.Core.CRUD.Models
{
    public class AircraftItem
    {
        public Guid Id { get; set; }
        public string Registration { get; set; }
        public bool HasSpecialLivery { get; set; }
        public DateTime FirstSeen { get; set; }
        public DateTime LastSeen { get; set; }
        public string AircraftTypeId { get; set; }
        public InputSelectItem[] AircraftTypes { get; set; }
        public string AirlineId { get; set; }
        public InputSelectItem[] Airlines { get; set; }
        public ICollection<string> AirportIds { get; set; }
        public InputSelectItem[] Airports { get; set; }
    }
}

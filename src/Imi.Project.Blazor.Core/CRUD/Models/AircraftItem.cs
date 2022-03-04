using System;

namespace Imi.Project.Blazor.Core.CRUD.Models
{
    public class AircraftItem
    {
        public int Id { get; set; }
        public string Registration { get; set; }
        public bool HasSpecialLivery { get; set; }
        public DateTime FirstSeen { get; set; }
        public DateTime LastSeen { get; set; }
        public Guid AircraftTypeId { get; set; }
        public InputSelectItem[] AircraftTypes { get; set; }
        public Guid AirlineId { get; set; }
        public InputSelectItem[] Airlines { get; set; }
        public Guid AirportId { get; set; }
        public InputCheckboxItem[] Airports { get; set; }
    }
}

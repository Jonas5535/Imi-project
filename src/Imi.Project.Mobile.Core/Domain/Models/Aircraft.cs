using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Imi.Project.Mobile.Core.Domain.Models
{
    public class Aircraft
    {
        public Guid Id { get; set; }
        public string Registration { get; set; }
        public bool HasSpecialLivery { get; set; }
        public DateTime FirstSeen { get; set; }
        public DateTime LastSeen { get; set; }
        public string Image { get; set; }
        public AircraftType AircraftType { get; set; }
        public Airline Airline { get; set; }
        public ICollection<Airport> Airports { get; set; } = new ObservableCollection<Airport>();
    }
}

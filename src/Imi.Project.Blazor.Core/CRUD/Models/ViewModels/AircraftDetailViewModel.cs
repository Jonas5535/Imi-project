using Imi.Project.Blazor.Core.CRUD.Models.EntityModels;
using System;
using System.Collections.Generic;

namespace Imi.Project.Blazor.Core.CRUD.Models.ViewModels
{
    public class AircraftDetailViewModel
    {
        public Guid Id { get; set; }
        public string Registration { get; set; }
        public bool HasSpecialLivery { get; set; }
        public DateTime FirstSeen { get; set; }
        public DateTime LastSeen { get; set; }
        public string Image { get; set; }
        public double? Longitude { get; set; }
        public double? Latitude { get; set; }
        public AircraftType AircraftType { get; set; }
        public Airline Airline { get; set; }
        public ICollection<Airport> Airports { get; set; }

    }
}

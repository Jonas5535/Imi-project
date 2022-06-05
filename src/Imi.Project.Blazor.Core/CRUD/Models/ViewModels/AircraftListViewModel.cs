using Imi.Project.Blazor.Core.CRUD.Models.EntityModels;
using System;
using System.Collections.Generic;

namespace Imi.Project.Blazor.Core.CRUD.Models.ViewModels
{
    public class AircraftListViewModel
    {
        public Guid Id { get; set; }
        public string Image { get; set; }
        public string Registration { get; set; }
        public AircraftType AircraftType { get; set; }
        public Airline Airline { get; set; }
        public bool HasSpecialLivery { get; set; }
        public ICollection<Airport> Airports { get; set; }
    }
}

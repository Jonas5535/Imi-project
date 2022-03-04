using System;

namespace Imi.Project.Blazor.Core.CRUD.Models
{
    public class AircraftListItem
    {
        public Guid Id { get; set; }
        public string Registration { get; set; }
        public string AircraftType { get; set; }
        public string Airline { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Imi.Project.Wpf.Core.ApiModels
{
    public class ApiAircraftRequest
    {
        public Guid Id { get; set; }
        public string Registration { get; set; }
        public bool? HasSpecialLivery { get; set; }
        public DateTime? FirstSeen { get; set; }
        public DateTime? LastSeen { get; set; }
        public Guid AirlineId { get; set; }
        public Guid AircraftTypeId { get; set; }
        public ICollection<Guid> AirportIds { get; set; }
    }
}

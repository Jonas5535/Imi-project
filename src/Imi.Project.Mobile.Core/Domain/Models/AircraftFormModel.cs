using Plugin.Media.Abstractions;
using System;
using System.Collections.Generic;

namespace Imi.Project.Mobile.Core.Domain.Models
{
    public class AircraftFormModel
    {
        public string Registration { get; set; }
        public bool HasSpecialLivery { get; set; }
        public DateTime FirstSeen { get; set; }
        public DateTime LastSeen { get; set; }
        public MediaFile Image { get; set; }
        public Guid AirlineId { get; set; }
        public Guid AircraftTypeId { get; set; }
        public List<Guid> AirportIds { get; set; }
    }
}

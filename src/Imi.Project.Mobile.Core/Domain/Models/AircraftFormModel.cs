using Plugin.Media.Abstractions;
using System;
using System.Collections.Generic;
using System.IO;

namespace Imi.Project.Mobile.Core.Domain.Models
{
    public class AircraftFormModel
    {
        public Guid Id { get; set; }
        public string Registration { get; set; }
        public bool HasSpecialLivery { get; set; }
        public DateTime FirstSeen { get; set; }
        public DateTime LastSeen { get; set; }
        public Stream Image { get; set; }
        public Guid AirlineId { get; set; }
        public Guid AircraftTypeId { get; set; }
        public List<Guid> AirportIds { get; set; }
    }
}

using System;

namespace Imi.Project.Mobile.Core.Domain.Models
{
    public class AircraftType
    {
        public Guid Id { get; set; }
        public string Brand { get; set; }
        public string Type { get; set; }
        public string ICAOCode { get; set; }
        public DateTime FirstFlight { get; set; }
        public double Lentgh { get; set; }
        public double WingSpan { get; set; }
        public double Height { get; set; }
        public int MaxCapacity { get; set; }
    }
}

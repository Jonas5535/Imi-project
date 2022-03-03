using System;

namespace Imi.Project.Mobile.Core.Domain.Models
{
    public class Airline
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string IATACode { get; set; }
        public string ICAOCode { get; set; }
        public string MainAirport { get; set; }
        public string HeadQuarter { get; set; }
        public int? FleetSize { get; set; }
    }
}

using System;

namespace Imi.Project.Mobile.Core.Domain.Models
{
    public class Airport
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string IATACode { get; set; }
        public string ICAOCode { get; set; }
        public double HeightAMSL { get; set; }
        public int RunwayAmount { get; set; }
        public int TerminalAmount { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
    }
}

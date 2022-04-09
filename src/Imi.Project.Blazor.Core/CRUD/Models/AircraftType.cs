using System;

namespace Imi.Project.Blazor.Core.CRUD.Models
{
    public class AircraftType
    {
        public Guid Id { get; set; }
        public string Brand { get; set; }
        public string Type { get; set; }
        public string ICAOCode { get; set; }
    }
}

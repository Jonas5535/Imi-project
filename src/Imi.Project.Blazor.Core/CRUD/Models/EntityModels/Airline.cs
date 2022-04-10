using System;

namespace Imi.Project.Blazor.Core.CRUD.Models
{
    public class Airline
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string IATACode { get; set; }
        public string ICAOCode { get; set; }
    }
}

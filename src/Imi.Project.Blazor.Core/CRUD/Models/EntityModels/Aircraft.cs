using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Imi.Project.Blazor.Core.CRUD.Models
{
    public class Aircraft
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [DataType(DataType.Text)]
        [MinLength(6, ErrorMessage = "{0} must be {1} characters long")]
        [MaxLength(6, ErrorMessage = "{0} must be {1} characters long")]
        public string Registration { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        public bool HasSpecialLivery { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [DataType(DataType.Date)]
        public DateTime FirstSeen { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [DataType(DataType.Date)]
        public DateTime LastSeen { get; set; }

        public string Image { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        public Guid AircraftTypeId { get; set; }
        public AircraftType AircraftType { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        public Guid AirlineId { get; set; }
        public Airline Airline { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        public ICollection<Guid> AirportIds { get; set; }
        public ICollection<Airport> Airports { get; set; }
    }
}

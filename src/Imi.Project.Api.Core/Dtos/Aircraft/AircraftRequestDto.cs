using Imi.Project.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Imi.Project.Api.Core.Dtos
{
    public class AircraftRequestDto : BaseDto
    {
        [Required(ErrorMessage = "{0} is required")]
        [DataType(DataType.Text)]
        [MinLength(6, ErrorMessage = "{0} must be {1} characters long")]
        [MaxLength(6, ErrorMessage = "{0} must be {1} characters long")]
        public string Registration { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        public bool HasSpecialLivery { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [DataType(DataType.Date)]
        [CurrentDate(ErrorMessage = "{0} cannot be later than today")]
        public DateTime FirstSeen { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [DataType(DataType.Date)]
        [CurrentDate(ErrorMessage = "{0} cannot be later than today")]
        public DateTime LastSeen { get; set; }

        // These two properties are also not required
        // They serve as gps coördinates but not every platform has gps service
        //public double? Longitude { get; set; } //Not yet in use
        //public double? Latitude { get; set; } //Not yet in use

        [Required(ErrorMessage = "{0} is required")]
        public Guid AirlineId { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        public Guid AircraftTypeId { get; set; }

        [Required(ErrorMessage = "{0} is required")] //This does not trigger if you leave the list empty, because it only checks if the list exists
        public List<Guid> AirportIds { get; set; }
    }
}

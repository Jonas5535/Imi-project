using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Imi.Project.Api.Core.Dtos.Aircraft
{
    public class AircraftRequestDto : BaseDto
    {
        [Required(ErrorMessage = "{0} is required")]
        [DataType(DataType.Text)]
        public string Registration { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        public bool HasSpecialLivery { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [DataType(DataType.Date)]
        public DateTime FirstSeen { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [DataType(DataType.Date)]
        public DateTime LastSeen { get; set; }

        // Image is not required as this is just an option
        [DataType(DataType.ImageUrl)]
        public string Image { get; set; }

        // These two properties are also not required
        // They serve as gps coördinates but not every platform has gps service
        public double? Longitude { get; set; }
        public double? Latitude { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        public Guid AirlineId { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        public Guid AircraftTypeId { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        public List<Guid> AirportIds { get; set; }
    }
}

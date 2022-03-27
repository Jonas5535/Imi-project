using System;
using System.ComponentModel.DataAnnotations;

namespace Imi.Project.Api.Core.Dtos
{
    public class AirlineRequestDto : BaseDto
    {
        [Required(ErrorMessage = "{0} is required")]
        [DataType(DataType.Text)]
        [MinLength(3, ErrorMessage = "{0} must be longer than {1} characters")]
        [MaxLength(150, ErrorMessage = "{0} must be shorter than or equal to {1} characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [DataType(DataType.Text)]
        [MinLength(2, ErrorMessage = "{0} must be {1} characters long")]
        [MaxLength(2, ErrorMessage = "{0} must be {1} characters long")]
        public string IATACode { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [DataType(DataType.Text)]
        [MinLength(3, ErrorMessage = "{0} must be {1} character long")]
        [MaxLength(3, ErrorMessage = "{0} must be {1} characters long")]
        public string ICAOCode { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [DataType (DataType.Text)]
        [MinLength(3, ErrorMessage = "{0} must be at least {1} characters long")]
        [MaxLength(200, ErrorMessage = "{0} must be shorter than or equal to {1} characters")]
        public string MainAirport { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [DataType(DataType.Text)]
        [MinLength(3, ErrorMessage = "{0} must be at least {1} characters long")]
        [MaxLength(200, ErrorMessage = "{0} must be shorter than or equal to {1} characters")]
        public string HeadQuarter { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [Range(1, 1500, ErrorMessage = "{0} must be between {1} and {2}, {1} and {2} included")]
        public int? FleetSize { get; set; }
    }
}

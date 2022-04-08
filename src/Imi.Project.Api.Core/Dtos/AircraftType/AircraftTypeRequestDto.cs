using System;
using System.ComponentModel.DataAnnotations;

namespace Imi.Project.Api.Core.Dtos
{
    public class AircraftTypeRequestDto : BaseDto
    {
        [Required(ErrorMessage = "{0} is required")]
        [DataType(DataType.Text)]
        [MinLength(3, ErrorMessage = "{0} must be longer than or equal to {1} characters")]
        [MaxLength(50, ErrorMessage = "{0} must be shorter than or equal to {1} characters")]
        public string Brand { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [DataType(DataType.Text)]
        [MinLength(3, ErrorMessage = "{0} must be longer than or equal to {1} characters")]
        [MaxLength(30, ErrorMessage = "{0} must be shorter than or equal to {1} characters")]
        public string Type { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [DataType(DataType.Text)]
        [MinLength(4, ErrorMessage = "{0} must be {1} characters long")]
        [MaxLength(4, ErrorMessage = "{0} must be {1} characters long")]
        public string ICAOCode { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [DataType(DataType.Date)]
        public DateTime? FirstFlight { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [Range(1, 100, ErrorMessage = "{0} must be between {1} and {2}, {1} and {2} included")]
        public double? Length { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [Range(1, 200, ErrorMessage = "{0} must be between {1} and {2}, {1} and {2} included")]
        public double? WingSpan { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [Range(1, 100, ErrorMessage = "{0} must be between {1} and {2}, {1} and {2} included")]
        public double? Height { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [Range(1, 500000, ErrorMessage = "{0} must be between {1} and {2}, {1} and {2} included")]
        public int? EmptyWeight { get; set; }
    }
}

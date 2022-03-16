using System;
using System.ComponentModel.DataAnnotations;

namespace Imi.Project.Api.Core.Dtos.AircraftType
{
    public class AircraftTypeRequestDto : BaseDto
    {
        [Required(ErrorMessage = "{0} is required")]
        public string Brand { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        public string Type { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        public string ICAOCode { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        public DateTime? FirstFlight { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        public double? Length { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        public double? WingSpan { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        public double? Height { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        public int? EmptyWeight { get; set; }
    }
}

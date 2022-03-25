using System;
using System.ComponentModel.DataAnnotations;

namespace Imi.Project.Api.Core.Dtos.AircraftType
{
    public class AircraftTypeRequestDto : BaseDto
    {
        public DateTime? AddedOn { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [DataType(DataType.Text)]
        public string Brand { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [DataType(DataType.Text)]
        public string Type { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [DataType(DataType.Text)]
        public string ICAOCode { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [DataType(DataType.Date)]
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

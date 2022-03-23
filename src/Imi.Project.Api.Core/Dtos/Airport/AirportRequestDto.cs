using System.ComponentModel.DataAnnotations;

namespace Imi.Project.Api.Core.Dtos.Airport
{
    public class AirportRequestDto : BaseDto
    {
        [Required(ErrorMessage = "{0} is required")]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [DataType(DataType.Text)]
        public string IATACode { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [DataType(DataType.Text)]
        public string ICAOCode { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        public int? ElevationAMSL { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        public int? RunwayAmount { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        public int? TerminalAmount { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [DataType(DataType.Text)]
        public string Country { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [DataType(DataType.Text)]
        public string City { get; set; }
    }
}

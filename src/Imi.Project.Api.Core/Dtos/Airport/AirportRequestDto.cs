using System;
using System.ComponentModel.DataAnnotations;

namespace Imi.Project.Api.Core.Dtos.Airport
{
    public class AirportRequestDto : BaseDto
    {
        public DateTime? AddedOn { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [DataType(DataType.Text)]
        [MaxLength(200, ErrorMessage = "{0} must be shorter than or equal to {1} characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [DataType(DataType.Text)]
        // Onderstaande annotatie valideert enkel de maximumlengte en niet de minimumlengte. Nochtans staat er in de beschrijving dit ze beiden gevalideerd worden.
        //[StringLength(3, ErrorMessage = "{0} must be {1} characters long")]
        [MinLength(3, ErrorMessage = "{0} must be {1} characters long")]
        [MaxLength(3, ErrorMessage = "{0} must be {1} characters long")]
        public string IATACode { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [DataType(DataType.Text)]
        // Idem van IATACode
        //[StringLength(4, ErrorMessage = "{0} must be {1} characters long")]
        [MinLength(4, ErrorMessage = "{0} must be {1} characters long")]
        [MaxLength(4, ErrorMessage = "{0} must be {1} characters long")]
        public string ICAOCode { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [Range(-400, 5000, ErrorMessage = "{0} must be greater than {1} and smaller than {2}")]
        public int? ElevationAMSL { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [Range(1, 15, ErrorMessage = "{0} must be between {1} and {2}, {1} and {2} included")]
        public int? RunwayAmount { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [Range(0, 20, ErrorMessage = "{0} must be between {1} and {2}, {1} and {2} included")]
        public int? TerminalAmount { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [DataType(DataType.Text)]
        [MinLength(4, ErrorMessage = "{0} must be at least {1} characters long")]
        [MaxLength(200, ErrorMessage = "{0} must be shorter than or equal to {1} characters")]
        public string Country { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [DataType(DataType.Text)]
        [MaxLength(200, ErrorMessage = "{0} must be shorter than or equal to {1} characters")]
        public string City { get; set; }
    }
}

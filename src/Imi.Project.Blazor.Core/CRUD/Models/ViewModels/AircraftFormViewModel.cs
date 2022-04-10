using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Imi.Project.Blazor.Core.CRUD.Models.ViewModels
{
    public class AircraftFormViewModel
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

        [Required(ErrorMessage = "{0} is required")]
        public Guid AircraftTypeId { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        public Guid AirlineId { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        public ICollection<Guid> AirportIds { get; set; }
    }
}

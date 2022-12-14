using Imi.Project.Blazor.Core.CRUD.CustomValidationAttributes;
using Imi.Project.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Imi.Project.Blazor.Core.CRUD.Models.ViewModels
{
    public class AircraftFormViewModel
    {
        public Guid Id { get; set; }

        [Display(Name = "Registratienummer")]
        [Required(ErrorMessage = "{0} is verplicht")]
        [DataType(DataType.Text, ErrorMessage = "{0} moet gewone tekst zijn")]
        [MinLength(6, ErrorMessage = "{0} moet {1} karakters lang zijn")]
        [MaxLength(6, ErrorMessage = "{0} moet {1} karakters lang zijn")]
        public string Registration { get; set; }

        [Display(Name = "Special livery")]
        [Required(ErrorMessage = "{0} is verplicht")]
        public bool HasSpecialLivery { get; set; }

        [Display(Name = "Eerst gezien")]
        [Required(ErrorMessage = "{0} is verplicht")]
        [DataType(DataType.Date, ErrorMessage = "{0} moet een datum zijn")]
        [CurrentDate(ErrorMessage = "De datum van {0} mag niet later zijn dan vandaag")]
        public DateTime FirstSeen { get; set; }

        [Display(Name = "Laatst gezien")]
        [Required(ErrorMessage = "{0} is verplicht")]
        [DataType(DataType.Date, ErrorMessage = "{0} moet een datum zijn")]
        [CurrentDate(ErrorMessage = "De datum van {0} mag niet later zijn dan vandaag")]
        public DateTime LastSeen { get; set; }

        [Display(Name = "Afbeelding")]
        [DataType(DataType.Upload, ErrorMessage = "{0} moet een bestand zijn")]
        [CheckFileType(ErrorMessage = "{0} moet van het type jpg of png zijn")]
        [CheckFileSize(ErrorMessage = "De grootte van de {0} moet kleiner of gelijk zijn aan 2MB")]
        public ImageFile Image { get; set; }

        public double? Longitude { get; set; }
        public double? Latitude { get; set; }

        [Display(Name = "Vliegtuigtype")]
        [Required(ErrorMessage = "{0} is verplicht")]
        [NotEmptyGuid(ErrorMessage = "{0} is verplicht")] //Needed to trigger validation failure when user doesn't select value
        public Guid AircraftTypeId { get; set; }

        [Display(Name = "Maatschappij")]
        [Required(ErrorMessage = "{0} is verplicht")]
        [NotEmptyGuid(ErrorMessage = "{0} is verplicht")]
        public Guid AirlineId { get; set; }

        [Display(Name = "Luchthaven")]
        [Required(ErrorMessage = "{0} is verplicht")]
		[NotEmptyCollection(ErrorMessage = "{0} is verplicht")]
		public ICollection<Guid> AirportIds { get; set; }
    }
}

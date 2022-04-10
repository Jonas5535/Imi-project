﻿using Imi.Project.Shared.CustomValidationAttributes;
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
        [DataType(DataType.Text)]
        [MinLength(6, ErrorMessage = "{0} moet {1} karakters lang zijn")]
        [MaxLength(6, ErrorMessage = "{0} moet {1} karakters lang zijn")]
        public string Registration { get; set; }

        [Display(Name = "Special livery")]
        [Required(ErrorMessage = "{0} is verplicht")]
        public bool HasSpecialLivery { get; set; }

        [Display(Name = "Eerst gezien")]
        [Required(ErrorMessage = "{0} is verplicht")]
        [DataType(DataType.Date)]
        [CurrentDate(ErrorMessage = "De datum van {0} mag niet later zijn dan vandaag")]
        public DateTime FirstSeen { get; set; }

        [Display(Name = "Laatst gezien")]
        [Required(ErrorMessage = "{0} is verplicht")]
        [DataType(DataType.Date)]
        [CurrentDate(ErrorMessage = "De datum van {0} mag niet later zijn dan vandaag")]
        //[LaterThan(nameof(FirstSeen), ErrorMessage = "De datum van {0} mag zijn vroeger zijn dan {1}")] //Werkt niet.
        //TODO Hulp vragen aan lector
        public DateTime LastSeen { get; set; }

        [Display(Name = "Vliegtuigtype")]
        [Required(ErrorMessage = "{0} is verplicht")]
        public Guid AircraftTypeId { get; set; }

        [Display(Name = "Maatschappij")]
        [Required(ErrorMessage = "{0} is verplicht")]
        public Guid AirlineId { get; set; }

        [Display(Name = "Luchthaven")]
        [Required(ErrorMessage = "{0} is verplicht")]
        public ICollection<Guid> AirportIds { get; set; }
    }
}

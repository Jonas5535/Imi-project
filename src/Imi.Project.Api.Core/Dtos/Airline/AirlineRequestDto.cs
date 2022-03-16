﻿using System.ComponentModel.DataAnnotations;

namespace Imi.Project.Api.Core.Dtos.Airline
{
    public class AirlineRequestDto : BaseDto
    {
        [Required(ErrorMessage = "{0} is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        public string IATACode { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        public string ICAOCode { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        public string MainAirport { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        public string HeadQuarter { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        public int? FleetSize { get; set; }
    }
}
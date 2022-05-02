﻿using Imi.Project.Blazor.Core.CRUD.Models.EntityModels;
using System;

namespace Imi.Project.Blazor.Core.CRUD.Models.ViewModels
{
    public class AircraftListViewModel
    {
        public Guid Id { get; set; }
        public string Image { get; set; }
        public string Registration { get; set; }
        public AircraftType AircraftType { get; set; }
        public Airline Airline { get; set; }
    }
}

using FluentValidation;
using FreshMvvm;
using Imi.Project.Mobile.Core.Domain.Models;
using Imi.Project.Mobile.Core.Domain.Services;
using Imi.Project.Mobile.Core.Domain.Validators;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Mobile.ViewModels
{
    public class AirlineFormViewModel : FreshBasePageModel
    {
        private readonly ICRUDService<Airline> _airlineService;
        private readonly IValidator _airlineValidator;
        private Airline _currentAirline;
        private bool _isNew = true;

        public AirlineFormViewModel(ICRUDService<Airline> airlineService)
        {
            _airlineService = airlineService;
            _airlineValidator = new AirlineValidator();
        }

        #region Properties

        #endregion
    }
}

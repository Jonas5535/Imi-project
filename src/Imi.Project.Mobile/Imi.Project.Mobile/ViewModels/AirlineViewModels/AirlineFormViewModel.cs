using FluentValidation;
using FreshMvvm;
using Imi.Project.Mobile.Core.Domain.Models;
using Imi.Project.Mobile.Core.Domain.Services;
using Imi.Project.Mobile.Core.Domain.Validators;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

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
        private string pageTitle;

        public string PageTitle
        {
            get { return pageTitle; }
            set
            {
                pageTitle = value;
                RaisePropertyChanged(nameof(PageTitle));
            }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                RaisePropertyChanged(nameof(Name));
            }
        }

        private string iataCode;

        public string IATACode
        {
            get { return iataCode; }
            set
            {
                iataCode = value;
                RaisePropertyChanged(nameof(IATACode));
            }
        }

        private string icaoCode;

        public string ICAOCode
        {
            get { return icaoCode; }
            set
            {
                icaoCode = value;
                RaisePropertyChanged(nameof(ICAOCode));
            }
        }

        #endregion

        public async override void Init(object initData)
        {
            base.Init(initData);

            _currentAirline = initData as Airline;

            await RefreshAirline();
        }

        private async Task RefreshAirline()
        {
            if(_currentAirline == null)
            {
                _currentAirline = new Airline();
                _currentAirline.Id = Guid.NewGuid();
                PageTitle = "Nieuwe maatschappij";
            }
            else
            {
                _isNew = false;
                _currentAirline = await _airlineService.GetByIdAsync(_currentAirline.Id);
                PageTitle = $"{_currentAirline.Name} bewerken";
            }
            LoadAirlineState();
        }

        private void LoadAirlineState()
        {
            Name = _currentAirline.Name;
            IATACode = _currentAirline.IATACode;
            ICAOCode = _currentAirline.ICAOCode;
        }

        private void SaveAirlineState()
        {
            _currentAirline.Name = Name;
            _currentAirline.IATACode = IATACode;
            _currentAirline.ICAOCode = ICAOCode;
        }
    }
}

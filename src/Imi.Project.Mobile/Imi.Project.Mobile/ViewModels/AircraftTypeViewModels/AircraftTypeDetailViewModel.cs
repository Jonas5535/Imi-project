using FreshMvvm;
using Imi.Project.Mobile.Core.Domain.Models;
using Imi.Project.Mobile.Core.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Mobile.ViewModels
{
    public class AircraftTypeDetailViewModel : FreshBasePageModel
    {
        private readonly ICRUDService<AircraftType> _aircraftTypeService;

        public AircraftTypeDetailViewModel(ICRUDService<AircraftType> aircraftTypeService)
        {
            _aircraftTypeService = aircraftTypeService;
        }

        private AircraftType shownType;

        public AircraftType ShownType
        {
            get { return shownType; }
            set
            {
                shownType = value;
                RaisePropertyChanged();
            }
        }

        public override void Init(object initData)
        {
            base.Init(initData);
            ShownType = initData as AircraftType;
        }

        public override void ReverseInit(object returnedData)
        {
            ShownType = null;
            ShownType = returnedData as AircraftType;
        }
    }
}

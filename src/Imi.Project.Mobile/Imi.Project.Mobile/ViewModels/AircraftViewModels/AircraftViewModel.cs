using FreshMvvm;
using Imi.Project.Mobile.Core.Domain.Models;
using Imi.Project.Mobile.Core.Domain.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Imi.Project.Mobile.ViewModels
{
    public class AircraftViewModel : FreshBasePageModel
    {
        private readonly ICRUDService<Aircraft> _aircraftService;

        public AircraftViewModel(ICRUDService<Aircraft> aircraftService)
        {
            _aircraftService = aircraftService;
        }

        private ObservableCollection<Aircraft> aircrafts;

        public ObservableCollection<Aircraft> Aircrafts
        {
            get { return aircrafts; }
            set
            {
                aircrafts = value;
                RaisePropertyChanged();
            }
        }

        protected async override void ViewIsAppearing(object sender, EventArgs e)
        {
            base.ViewIsAppearing(sender, e);
            await ListInit();
        }

        public ICommand OpenAircraftDetailPageCommand => new Command<Aircraft>(
            async (Aircraft aircraft) =>
            {
                await CoreMethods.PushPageModel<AircraftDetailViewModel>(aircraft);
            }
        );

        public ICommand OpenFilterPageCommand => new Command(
            async () =>
            {
                await CoreMethods.PushPageModel<FilterViewModel>();
            }
        );

        public ICommand AddAircraftCommand => new Command(
            async () =>
            {
                await CoreMethods.PushPageModel<AircraftFormViewModel>();
            }
        );

        public ICommand EditAircraftCommand => new Command<Aircraft>(
            async (Aircraft aircraft) =>
            {
                await CoreMethods.PushPageModel<AircraftFormViewModel>(aircraft);
            }
        );

        public ICommand DeleteAircraftCommand => new Command<Aircraft>(
            async (Aircraft aircraft) =>
            {
                await _aircraftService.DeleteAsync(aircraft.Id); //TODO handle BaseResponse
                await ListInit();
            }
        );

        private async Task ListInit()
        {
            BaseResponse<ICollection<Aircraft>> response = await _aircraftService.ListAllAsync();

            if (!response.IsSucces)
            {
                throw new NotImplementedException(); //TODO Handle unsuccesful response
            }

            ObservableCollection<Aircraft> aircrafts = new ObservableCollection<Aircraft>(response.Data);
            Aircrafts = null;
            Aircrafts = aircrafts;
        }
    }
}

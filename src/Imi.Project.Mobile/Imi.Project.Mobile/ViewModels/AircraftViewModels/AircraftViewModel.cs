using FreshMvvm;
using Imi.Project.Mobile.Core.Domain.Models;
using Imi.Project.Mobile.Core.Domain.Services;
using System;
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
                await _aircraftService.DeleteAsync(aircraft.Id);
            }
        );

        private async Task ListInit()
        {
            ObservableCollection<Aircraft> aircrafts = await _aircraftService.ListAllAsync();
            Aircrafts = null;
            Aircrafts = aircrafts;
        }
    }
}

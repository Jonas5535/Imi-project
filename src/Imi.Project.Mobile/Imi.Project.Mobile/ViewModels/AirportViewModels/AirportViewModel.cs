using FreshMvvm;
using Imi.Project.Mobile.Core.Domain.Models;
using Imi.Project.Mobile.Core.Domain.Services;
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.ViewModels
{
    public class AirportViewModel : FreshBasePageModel
    {
        private readonly ICRUDService<Airport> _airportService;

        public AirportViewModel(ICRUDService<Airport> airportService)
        {
            _airportService = airportService;
        }

        private ObservableCollection<Airport> airports;

        public ObservableCollection<Airport> Airports
        {
            get { return airports; }
            set
            {
                airports = value;
                RaisePropertyChanged(nameof(Airports));
            }
        }

        protected async override void ViewIsAppearing(object sender, EventArgs e)
        {
            base.ViewIsAppearing(sender, e);
            await ListInit();
        }

        private async Task ListInit()
        {
            ObservableCollection<Airport> airports = await _airportService.ListAllAsync();
            Airports = null;
            Airports = airports;
        }
    }
}

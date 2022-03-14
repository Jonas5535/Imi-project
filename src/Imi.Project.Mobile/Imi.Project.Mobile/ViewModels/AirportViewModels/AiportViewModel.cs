using FreshMvvm;
using Imi.Project.Mobile.Core.Domain.Models;
using Imi.Project.Mobile.Core.Domain.Services;
using System.Collections.ObjectModel;

namespace Imi.Project.Mobile.ViewModels
{
    public class AiportViewModel : FreshBasePageModel
    {
        private readonly ICRUDService<Airport> _airportService;

        public AiportViewModel(ICRUDService<Airport> airportService)
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

    }
}

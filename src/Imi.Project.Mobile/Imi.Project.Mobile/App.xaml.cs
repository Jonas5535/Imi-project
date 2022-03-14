using FluentValidation;
using FreshMvvm;
using Imi.Project.Mobile.Core.Domain.Models;
using Imi.Project.Mobile.Core.Domain.Services;
using Imi.Project.Mobile.Core.Domain.Services.Mocking;
using Imi.Project.Mobile.Core.Domain.Validators;
using Imi.Project.Mobile.ViewModels;
using Xamarin.Forms;

namespace Imi.Project.Mobile
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new FreshNavigationContainer(FreshPageModelResolver.ResolvePageModel<MainViewModel>());

            //register dependencies
            FreshIOC.Container.Register<ICRUDService<Airline>>(new MockAirlineService());
            FreshIOC.Container.Register<ICRUDService<Airport>>(new MockAirportService());
            FreshIOC.Container.Register<IValidator>(new AirlineValidator());

            NavigationPage navigationPage = Current.MainPage as NavigationPage;
            navigationPage.BarBackgroundColor = Color.FromHex("#fdd31d");
            navigationPage.BarTextColor = Color.Black;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

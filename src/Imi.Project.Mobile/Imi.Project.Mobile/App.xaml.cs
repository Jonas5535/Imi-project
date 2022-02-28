using Imi.Project.Mobile.Views;
using Xamarin.Forms;

namespace Imi.Project.Mobile
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());

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

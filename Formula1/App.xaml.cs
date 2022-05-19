using Formula1.Views;
using Xamarin.Forms;

namespace Formula1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var mainViewModel = new ViewModel.DriversViewModel();
            MainPage = new NavigationPage(new DriversView(mainViewModel))
            {
                BarBackgroundColor = Color.FromHex("#9E4368"),
                BarTextColor = Color.White
            };
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

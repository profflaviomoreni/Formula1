using Formula1.Views;
using Xamarin.Forms;

namespace Formula1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new DriversView();
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

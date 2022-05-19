using Formula1.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Formula1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DriveDetailsView : ContentPage
    {
        public DriveDetailsView(DriverDetailsViewModel driverDetailsViewModel)
        {
            InitializeComponent();
            BindingContext = driverDetailsViewModel;
        }
    }
}
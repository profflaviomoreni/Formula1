using Formula1.Data;
using Formula1.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Formula1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DriversView : ContentPage
    {
        public DriversView(DriversViewModel driversViewModel)
        {
            InitializeComponent();
            BindingContext = driversViewModel;
        }

    }
}
using Formula1.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Formula1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DriversView : ContentPage
    {
        private DriverRepository driverRepository;
        public DriversView()
        {
            InitializeComponent();
            driverRepository = new DriverRepository();
            DriversList.ItemsSource = driverRepository.FindAll();
        }



        private void DriversList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            DisplayAlert("Teste", "Item Selecionado", "OK");

        }
    }
}
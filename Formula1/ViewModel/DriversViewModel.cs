using Formula1.Data;
using Formula1.Models;
using Formula1.Views;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace Formula1.ViewModel
{
    public class DriversViewModel : BaseViewModel
    {
        #region properties
        private ObservableCollection<Driver> drivers;
        public ObservableCollection<Driver> Drivers
        {
            get { return drivers; }
            set { SetProperty(ref drivers, value); }
        }


        private Driver selectedDriver;
        public Driver SelectedDriver
        {
            get { return selectedDriver; }
            set { SetProperty(ref selectedDriver, value); }
        }

        private DriverRepository driverRepository;
        #endregion

        #region commands
        public ICommand DriverSelectedCommand => new Command<Driver>(async (Driver driver) =>
        {
            var vm = new DriverDetailsViewModel(driver);
            await App.Current.MainPage.Navigation.PushAsync(new DriveDetailsView(vm));
        });


        #endregion


        public DriversViewModel()
        {
            driverRepository = new DriverRepository();
            Drivers = new ObservableCollection<Driver>(driverRepository.FindAll());
        }

    }
}

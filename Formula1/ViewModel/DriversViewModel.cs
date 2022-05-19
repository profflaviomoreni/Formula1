using Formula1.Data;
using Formula1.Models;
using System.Collections.ObjectModel;

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


        public DriversViewModel()
        {
            driverRepository = new DriverRepository();
            Drivers = new ObservableCollection<Driver>(driverRepository.FindAll());
        }

    }
}

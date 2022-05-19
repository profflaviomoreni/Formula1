using Formula1.Models;
using Formula1.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace Formula1.ViewModel
{
    public class MenuViewModel : BaseViewModel
    {

        #region properties
        private ObservableCollection<Models.Menu> menuItems;
        public ObservableCollection<Models.Menu> MenuItems
        {
            get { return menuItems; }
            set { SetProperty(ref menuItems, value); }
        }

        private Models.Menu menuSelected;

        public Models.Menu MenuSelected
        {
            get { return menuSelected; }
            set { SetProperty(ref menuSelected, value); }
        }
        #endregion


        public ICommand MenuCommand => new Command<Models.Menu>(async (Models.Menu itemMenu) =>
        {
            FlyoutPage flyOutPage = (FlyoutPage) App.Current.MainPage;

            var selectedPage = new NavigationPage();
            if (itemMenu.TargetType == typeof(Views.DriversView))
            {
                var vm = new DriversViewModel();
                var page = new DriversView(vm);
                selectedPage = new NavigationPage(page);

            } 
            else if (itemMenu.TargetType == typeof(Views.RacesView)) 
            {
                var vm = new RacesViewModel();
                var page = new RacesView(vm);
                selectedPage = new NavigationPage(page);
            }
            
            flyOutPage.Detail = selectedPage;
            flyOutPage.IsPresented = false;

        });


        public MenuViewModel()
        {
            var items = new List<Models.Menu>();
            
            items.Add(new Models.Menu
            {
                Title = "Drivers",
                IconSource = "Trophy_Black.png",
                TargetType = typeof(DriversView)
            });

            items.Add(new Models.Menu
            {
                Title = "Races",
                IconSource = "Calendar_Black.png",
                TargetType = typeof(RacesView)
            });


            MenuItems = new ObservableCollection<Models.Menu>(items);
        }
    }
}

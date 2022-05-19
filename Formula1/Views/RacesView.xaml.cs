using Formula1.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Formula1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RacesView : ContentPage
    {
        public RacesView(RacesViewModel racesViewModel)
        {
            InitializeComponent();
            BindingContext = racesViewModel;
        }
    }
}
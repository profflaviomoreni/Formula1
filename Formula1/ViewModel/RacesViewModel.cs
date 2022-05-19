using Formula1.Data;
using Formula1.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Formula1.ViewModel
{
    public class RacesViewModel : BaseViewModel
    {
        #region properties
        private ObservableCollection<Race> races;
        public ObservableCollection<Race> Races
        {
            get { return races; }
            set { SetProperty(ref races, value); }
        }


        
        private RacesRepository racesRepository;
        #endregion


        public RacesViewModel()
        {
            racesRepository = new RacesRepository();
            Races = new ObservableCollection<Race>( racesRepository.FindAll() );
        }
    }
}

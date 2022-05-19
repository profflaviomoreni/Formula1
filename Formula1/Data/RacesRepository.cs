using Formula1.Models;
using System;
using System.Collections.Generic;

namespace Formula1.Data
{
    public class RacesRepository
    {

        public IList<Race> FindAll()
        {
            return new List<Race>()
            {
                new Race
                {
                    Name="Australian Grand Prix",
                    Circuit="Melbourne",
                    CircuitLength=5.303,
                    RaceDistance=307.574,
                    NumberOfLaps=58,
                    Date = new DateTime(2017, 03, 26),
                    MapUrl = @"https://www.formula1.com/content/fom-website/en/championship/races/2017/Australia/_jcr_content/circuitMap.img.png/1458295855148.png"
                },
                new Race
                {
                    Name="Chinese Grand Prix",
                    Circuit="Shanghai International Circuit",
                    CircuitLength=5.451,
                    RaceDistance=305.066,
                    NumberOfLaps=56,
                    Date = new DateTime(2017, 04, 09)
                },
                new Race
                {
                    Name="Bahrain Grand Prix",
                    Circuit="Bahrain International Circuit",
                    CircuitLength=5.451,
                    RaceDistance=305.066,
                    NumberOfLaps=56,
                    Date = new DateTime(2017, 04, 16)
                },
                new Race
                {
                    Name="Russian Grand Prix",
                    Circuit="Sochi Autodrom",
                    CircuitLength=5.848,
                    RaceDistance=305.066,
                    NumberOfLaps=53,
                    Date = new DateTime(2017, 04, 30)
                },
                new Race
                {
                    Name="Premio De Espana",
                    Circuit="Circuit De Barcelona-Catalunya",
                    CircuitLength=4.655,
                    RaceDistance=307.104,
                    NumberOfLaps=66,
                    Date = new DateTime(2017, 05, 14)
                },
                new Race
                {
                    Name="Grand Prix De Monaco",
                    Circuit="Circuit De Monaco",
                    CircuitLength=3.337,
                    RaceDistance=260.286,
                    NumberOfLaps=78,
                    Date = new DateTime(2017, 05, 28)
                },
                new Race
                {
                    Name="Grand Prix Du Canada",
                    Circuit="Circuit Gilles-Villeneuve",
                    CircuitLength=361,
                    RaceDistance=305.27,
                    NumberOfLaps=70,
                    Date = new DateTime(2017, 06, 11),
                    IsLast=true
                },

            };
        }
    }
}

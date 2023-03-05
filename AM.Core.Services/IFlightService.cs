using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Services
{
    internal interface IFlightService
    {
        // Question4 TP2
        public IList<DateTime> GetFlightsDate(string destination);
        // Question5 Tp2 : void khater juste affichage mech retourne haja 
        public void GetFlights(string filterType, string filterValue);
    }
}

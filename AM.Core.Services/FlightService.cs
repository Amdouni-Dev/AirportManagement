using AM.Core.Domain; //Ajouter Refderence projet // double clik sur AM.Core.Services w najouti reference de projet elli howa AM.core.Domain
using AM.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Services
{
    public class FlightService:IFlightService
    {


        IRepository<Flight> repository;
        public FlightService(IRepository<Flight> repository)
        {
            this.repository = repository;
        }

        //Question2 Tp2
        public IList<Flight> Flights { get; set; }

        public void GetFlights(string filterType, string filterValue)
        {

            switch (filterType)
            {
                case "Destination":
                    foreach (var flight in Flights)
                    {
                        if (flight.Destination == filterValue)
                        {
                            Console.WriteLine(flight);
                        }
                    }
                    break;
                case "Departure":
                    foreach (var flight in Flights)
                    {
                        if (flight.Departure == filterValue)
                        {
                            Console.WriteLine(flight);
                        }
                    }
                    break;
                case "FlightDate":
                    foreach (var flight in Flights)
                    {
                        if (flight.FlightDate.ToString() == filterValue)
                        {
                            Console.WriteLine(flight);
                        }
                    }
                    break;
                case "FlightId":
                    foreach (var flight in Flights)
                    {
                        if (flight.FlightId.ToString() == filterValue)
                        {
                            Console.WriteLine(flight);
                        }
                    }
                    break;
                case "EffectiveArrival":

                    foreach (var flight in Flights)
                    {
                        // if (flight.EffectiveArrival == DateTime.Parse(filterValue))
                        if (flight.EffectiveArrival.ToString() == filterValue)
                        {
                            Console.WriteLine(flight);
                        }
                    }
                    break;
                case "EstimatedDuration":
                    try
                    {
                        foreach (var flight in Flights)
                        {
                            if (flight.estimationDuration == int.Parse(filterValue))
                            {
                                Console.WriteLine(flight);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("la valeur du filter n'est pas un int : ", ex.ToString());
                    }
                    break;
            }
        }


        //Question6 TP2

        public IList<DateTime> GetFlightsDate(string destination) // LinqIntegré
        {// na3ty destination w ykharejli la liste des dates
       
            return Flights.Where(f=>f.Destination== destination) // Methode d'extension
                .Select(f=> f.FlightDate).ToList();


          //  throw new NotImplementedException();
        }
        // Question 7 TP2
        public void showFlightDetails(Plane plane) 
        {
            var result = from f in Flights
                         where f.MyPlane.PlaneId == plane.PlaneId
                         select new { f.Destination, f.FlightDate };
            foreach(var item in result)
            {
                Console.WriteLine("Destination: " + item.Destination + " Date:" + item.FlightDate);
            }

        }
        // Question8 TP2
        public int GetWeeklyflightNumber(DateTime date)
        {
            return (from f in Flights
                         where f.FlightDate>= date // lezem ki na3tyb date au moins tkoun 9adha w ila akber menha bech nabda nehseb men wa9tha
                         && f.FlightDate < date.AddDays(7) // w jhedhy hkeyet eli lezem nraja3 les vols ken f jem3a bark a partir m date illi 3tytha 
                         select f).Count();
        }
        // Question 9 TP2
        public double GetDurationAverage(string destination)
        { 

            /*
             return (from f in Flights
                    where f.Destination == destination
                    select f.EstimatedDuration).Average();
             */
            var result = from f in Flights
                         where f.Destination == destination
                         select f.estimationDuration;
            return result.Average(); // Average ==> hiya Avg fel sql tehseb l moyenne direct
        }
        // Question 10 TP2
        public IList<Flight> Sortflights()
        {
            return (
                from f in Flights
                orderby f.estimationDuration descending // ascending ywalli croissant
                select f).ToList();

            
        }
        // Question 11 TP2
        public IList<Passenger> GetThreeOlderTravellers(Flight flight) 
        {

            return (
                from p in flight.passengers
                orderby p.Age descending // ordre decroissant bel age
                select p).Take(3).ToList(); // l max 3
                
                
        
        }

        // Question 12 Tp 2
        public void ShowGroupedFlights()
        {
            //var result = Flights.GroupBy(f => f.Destination);
            //foreach (var f in result)
            //{
            //    Console.WriteLine("resultat: " + f);
            //}

            // ********************Correction En class
            IEnumerable<IGrouping<string, Flight>> result = from f in Flights
                                                            group f by f.Destination;
            foreach (var Grp in result) // houni bech yboukli aal grps
            {
                Console.WriteLine(Grp.Key);
                foreach(var f in Grp) // houni bech nboukli aal les element eli fel grp
                {
                    Console.WriteLine(f);
                }
            }
        }


        // Question 13 Tp2
        //Un délégué est un type de données qui permet de stocker une référence à une méthode.
        //Il peut être considéré comme un pointeur de fonction dans d'autres langages de programmation.
        public delegate int GetScore(Passenger passenger);


        // Question 14 TP2
        //public Passenger GetSeniorPassenger(List<Passenger> passengers, GetScore getScoreMethod)
        //{
        //    double maxScore = double.MinValue;
        //    Passenger seniorPassenger = null;

        //    foreach (Passenger passenger in passengers)
        //    {
        //        double score = getScoreMethod(passenger);
        //        if (score > maxScore && passenger.Age >= 60)
        //        {
        //            maxScore = score;
        //            seniorPassenger = passenger;
        //        }
        //    }

        //    return seniorPassenger;
        //}

        // **************Correction En class

        public Passenger GetSeniorPassenger(IFlightService.GetScore meth)
        {



           //return  (from f in Flights
           //               from p in f.passengers
           //               orderby meth(p) descending
           //               select p).First();
            return null;
        }

        //TP6 --> Q2
        public void Add(Flight flight)
        {
            repository.Add(flight);
            repository.Commit();
        }
        public void Delete(Flight flight)
        {
            repository.Delete(flight); repository.Commit();
        }

        public IList<Flight> GetAll()
        {
            return repository.GetAll();
        }
    }
}

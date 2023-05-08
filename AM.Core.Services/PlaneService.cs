using AM.Core.Domain;
using AM.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Services
{
    public class PlaneService:Service<Plane> , IPlaneService
    {
        //IRepository<Plane> repository;
        //public PlaneService(IRepository<Plane> repository)
        //{
        //    this.repository = repository;
        //}
     // readonly  IUnitOfWork unitOfWork;
        public PlaneService(IUnitOfWork unitOfWork):base(unitOfWork) 
        {
            //this.unitOfWork = unitOfWork;
            //repository = unitOfWork.GetRepository<Plane>();
        }

        public IList<Flight> GetFlights(int n)
        {
            return GetAll() // recuperer tous les avions
                    .OrderByDescending(p => p.ManufactureDate)//ordonner les avions par dates de construction
                    .Take(n)//recuperer les n avions moins agées
                    .SelectMany(p => p.Flights) // recuperer tous les vols de tous les avions
                    .OrderBy(f => f.FlightDate) // ordoneer les vols par date de depart
                    .ToList();   
                
        }

        public bool IsAvailable(int n, Flight flight)
        {

            return flight.Reservations.Count() + n <= flight.MyPlane.Capacity;
              
        }

        public IList<Passenger> GetPassengers(Plane p)
        {
          return  Get(p.PlaneId).Flights
        .SelectMany(f => f.Reservations) // traja3 List mte3 list mte3 reser
        .Select(r => r.MyPassenger) // w houni kol res traja3li list mte3 passengers
        .Distinct().ToList();
                
        }

        public void DeleteUselessPlanes()
        {
            IList < Plane> planes   =GetAll()
                .Where (p=>p.Flights
                    .Any(f=>f.FlightDate.AddYears(1)>= DateTime.Now))
                .ToList();
            foreach(var p in planes)
            {
                Delete(p);
            }
        }


        //public void Add(Plane plane)
        //{
        //    repository.Add(plane);
        //    // repository.Commit();
        //    unitOfWork.Save();
        //}

        //public void Delete(Plane plane)
        //{
        //    repository.Delete(plane);
        //    // repository.Commit();
        //    unitOfWork.Save();
        //}

        //public IList<Plane> GetAll()
        //{
        //    return repository.GetAll();
        //}
    }
}

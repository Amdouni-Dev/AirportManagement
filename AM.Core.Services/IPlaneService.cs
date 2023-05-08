using AM.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Services
{
    public interface IPlaneService:IService<Plane>
    {

        
        // TP6 --> Q5
        //void Add(Plane plane);
        //void Delete(Plane plane);
        //IList<Plane> GetAll();

        // TP 6 Q13 .1
        IList<Passenger> GetPassengers(Plane p);
        IList<Flight> GetFlights(int n);
        bool IsAvailable(int n, Flight flight);
        void DeleteUselessPlanes();
    }
}

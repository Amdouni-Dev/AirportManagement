using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Domain
{

    public enum City
    {
        TUNIS=1,
            PARIS=2,
            LONDON=3,
            ALGERIE=4
    };

    //[Table("MyFlight")]
    public class Flight
    {
        public City Destination { get; set; }
        public City Departure { get; set; }
        public DateTime FlightDate { get; set; }
        //[Key] 
        public int FlightId { get; set; }
        public DateTime EffectiveArrival { get; set;}
        public int EstimatedDuration { get; set; }
        //[ForeignKey("PlaneId")] ou bien
        public virtual Plane? MyPlane { get; set; }

        [ForeignKey("MyPlane")]
        public int? PlaneId { get; set; } //prop
        //tp5 Q6
        //public IList<Passenger> passengers { get; set; }
        public virtual IList<Reservation> Reservations { get; set; }

        public String Comment { get; set; }
        public override string ToString()
        {
            return "Destination:" + Destination + ";"
                + "Departure:" + Departure + ";"
                + "FlightDate:" + FlightDate + ";"
                + "FlightId:" + FlightId + ";"
                + "EffectiveArrival:" + EffectiveArrival + ";"
                + "EstimatedDuration:" + EstimatedDuration;
        }
    }
}

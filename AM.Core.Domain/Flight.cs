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
    //[Table("MyFlight")]
    public class Flight
    {
        public string Destination { get; set; }
        public string Departure { get; set; }
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

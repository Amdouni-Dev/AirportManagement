using System;
using System.Collections.Generic;
using System.Linq;
//using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Domain
{
    public class Plane
    {
        public int Capacity { get; set; }
        public DateTime ManufactureDate { get; set; }
        public int PlaneId { get; set; }
        public PlaneType MyPlaneType { get; set; }
        public IList<Flight> Flights { get; set; }
        public override string ToString()
        {
            return "Capacity:" + Capacity + ";"
                + "ManufactureDate:" + ManufactureDate + ";"
                + "PlaneId:" + PlaneId + ";"
                + "PlaneType:" + MyPlaneType;
        }
        public Plane() { }
    
        public Plane(PlaneType pt,int capacity,DateTime date) {
           Capacity = capacity;
            ManufactureDate= date; 
            MyPlaneType= pt;
        }
    }
}

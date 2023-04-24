using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Domain
{
    public class Plane
    {
        [Range(0,int.MaxValue,ErrorMessage ="entier positive")]
        public int Capacity { get; set; }
        public DateTime ManufactureDate { get; set; }
        public int PlaneId { get; set; }
        public PlaneType MyPlaneType { get; set; }
        public virtual IList<Flight> Flights { get; set; }

        //TP1 Question 8   (constructeur) 
        public Plane()
        {

        }
        public Plane(PlaneType pt, int capacity, DateTime date)
        {
            Capacity = capacity;// on peut utiliser  this.Capacity = capacity; ou sans this (pour distinguer les noms)
            ManufactureDate = date;
            MyPlaneType = pt;
        }

        public override string ToString()
        {
            return "Capacity:" + Capacity + ";"
                + "ManufactureDate:" + ManufactureDate + ";"
                + "PlaneId:" + PlaneId + ";"
                + "PlaneType:" + MyPlaneType;
        }

        
    }
}


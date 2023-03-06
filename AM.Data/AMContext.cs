using AM.Core.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Data
{
    public class AMContext:DbContext
    {

         public DbSet<Passenger> Passengers { get; set; }
         public DbSet<Flight> Flights { get; set; }



        public DbSet<Plane> Planes { get; set; }

        public DbSet<Staff> Staffs { get; set; }

        public DbSet<Traveller> Travellers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) // options Builder nhotou fih les parametremte3 l bdd
        {
           
        optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb; 
        Initial Catalog = Airport;  
        Integrated Security = true");
           
           


           // base.OnConfiguring(optionsBuilder);
        }
    }
}

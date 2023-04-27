using AM.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Data.Configurations
{
    internal class FlightConfig : IEntityTypeConfiguration<Flight>
    {
        public void Configure(EntityTypeBuilder<Flight> builder)
        {

            // relation many to many Flight * -->  * Passenger
            builder
                .HasMany(f => f.passengers)
                .WithMany(p => p.flights);

            // relation Plane 1 --> * Flight
          builder
                .HasOne(f=>f.MyPlane) // relation 1
                .WithMany(p=>p.Flights) // chnowa ba3thetlha 
                .HasPrincipalKey(f=>f.PlaneId) // FK
                .OnDelete(DeleteBehavior.SetNull); // ki tetfassakh avion kol flight tebe3 l avion hedhykja  ywalli null 
        }
    }
}

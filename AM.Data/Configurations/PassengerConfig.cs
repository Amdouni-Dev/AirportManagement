﻿using AM.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Data.Configurations
{
    public class PassengerConfig : IEntityTypeConfiguration<Passenger>
    {
        public void Configure(EntityTypeBuilder<Passenger> builder)
        {
           builder
                .OwnsOne(p => p.FullName,full =>
                {
                    full.Property(f => f.FirstName)
                    .HasMaxLength(30)
                    .HasColumnName("Name");
                    full.Property(f => f.LastName)
                    .IsRequired();
                });
            //builder.HasDiscriminator<int>("IsTraveller")
            //    .HasValue<Passenger>(0)
            //    .HasValue<Traveller>(1)
            //    .HasValue<Staff>(2);



        }
    }
}

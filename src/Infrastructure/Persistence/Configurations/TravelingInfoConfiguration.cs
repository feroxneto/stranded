using CleanArchitecture.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Infrastructure.Persistence.Configurations
{
    class TravelingInfoConfiguration : IEntityTypeConfiguration<TravelingInfo>
    {
        public void Configure(EntityTypeBuilder<TravelingInfo> builder)
        {
            builder.Property(t => t.AirlineName)
                .HasMaxLength(50)
                .IsRequired();
             
            builder.HasOne(c => c.CityOfDestiny)
                .WithMany(c => c.TravelingInfoList)
                .HasForeignKey(t => t.CityOfDestinyId)
                .IsRequired()
                .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}

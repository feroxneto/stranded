using CleanArchitecture.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Infrastructure.Persistence.Configurations
{
    class CitizenConfiguration : IEntityTypeConfiguration<Citizen>
    {
        public void Configure(EntityTypeBuilder<Citizen> builder)
        {
            builder.Property(t => t.Name)
                .HasMaxLength(20)
                .IsRequired();
            builder.Property(t => t.Surname)
               .HasMaxLength(20)
               .IsRequired();

            builder.Property(t => t.DocumentNumber)
               .IsRequired()
               .HasMaxLength(50);


            builder.HasOne(c => c.CitizenshipType)
                .WithMany(c => c.CitizenList).IsRequired();

            builder.HasOne(c => c.DocumentType)
                .WithMany(c => c.CitizenList).IsRequired();

            builder.HasOne(c => c.Country)
                .WithMany(c => c.CitizenList)
                .HasForeignKey(c=>c.CountryId)
                .IsRequired();

            builder.HasOne(c => c.HealthStatus)
               .WithMany(c => c.CitizenList).IsRequired();


            builder.HasOne(c => c.N)
                .WithMany(c => c.CitizenList).IsRequired();

            builder.HasOne(c => c.Stranded)
                .WithMany(c => c.CitizenList).IsRequired();

            builder.HasOne(c => c.TravelingInfo)
                .WithOne(c => c.Citizen)
                .HasForeignKey<TravelingInfo>(ti=>ti.CitizenId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(c => c.VisitPurpose)
                .WithMany(c => c.CitizenList)
                .OnDelete(DeleteBehavior.ClientSetNull);
            

            builder.Property(t => t.PhoneNumber)
               .IsRequired()
               .HasMaxLength(20);

            builder.Property(t => t.PhoneNumberOther)
                .HasMaxLength(20);

            builder.Property(t => t.Email)
                .HasMaxLength(50);

            builder.Property(t => t.CurrentAddress)
                .HasMaxLength(100);

            builder.Property(t => t.PermanentResidenceAddress)
                .HasMaxLength(100);

            builder.Property(t => t.CitizenComment)
                .HasColumnType("ntext");

            builder.Property(t => t.AdminPublicComment)
                .HasColumnType("ntext");

            builder.Property(t => t.AdminInternalComment)
                .HasColumnType("ntext");

            builder.HasOne(c => c.LockOutCountry)
            .WithMany(c => c.LockedOutCitizenList)
            .HasForeignKey(lc=>lc.LockOutCountryId)
            .OnDelete(DeleteBehavior.ClientSetNull);


            builder.HasOne(c => c.LockOutCity)
            .WithMany(c => c.LockedOutCitizenList)
            .HasForeignKey(lc => lc.LockOutCityId)
            .OnDelete(DeleteBehavior.ClientSetNull);

            builder.Property(t => t.IsActive)
               .HasDefaultValue(true)
               .IsRequired();
        }
    }
}

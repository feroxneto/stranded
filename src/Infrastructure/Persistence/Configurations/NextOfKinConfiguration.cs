using CleanArchitecture.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Infrastructure.Persistence.Configurations
{
    class NextOfKinConfiguration : IEntityTypeConfiguration<NextOfKin>
    {
        public void Configure(EntityTypeBuilder<NextOfKin> builder)
        {
            builder.Property(t => t.Name)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(t => t.Surname)
               .HasMaxLength(50)
               .IsRequired();
            builder.HasOne(r => r.RelationshipType)
                .WithMany(nok => nok.NextOfKinList)
                .HasForeignKey(nok=>nok.RelationshipTypeId);

            builder.HasOne(r => r.Country)
              .WithMany(nok => nok.NextOfKinList)
              .HasForeignKey(nok => nok.CountryId);


            builder.Property(t => t.PhoneNumber)
             .IsRequired()
             .HasMaxLength(20);

            builder.Property(t => t.PhoneNumberOther)
                .HasMaxLength(20);

            builder.Property(t => t.Email)
                .HasMaxLength(50);


            builder.HasOne(t => t.Citizen)
            .WithMany(i => i.NextOfKinList).OnDelete(DeleteBehavior.ClientCascade);

            builder.Property(t => t.IsActive)
               .HasDefaultValue(true)
               .IsRequired();
        }
    }
}

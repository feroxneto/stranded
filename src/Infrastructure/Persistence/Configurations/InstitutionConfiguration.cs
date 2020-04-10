using CleanArchitecture.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Infrastructure.Persistence.Configurations
{
    class InstitutionConfiguration : IEntityTypeConfiguration<Institution>
    {
        public void Configure(EntityTypeBuilder<Institution> builder)
        {
            builder.Property(t => t.Name)
                .HasMaxLength(250)
                .IsRequired();

            builder.Property(t => t.PhoneNumber)
                .HasMaxLength(20);

            builder.Property(t => t.PhoneNumberOther)
                .HasMaxLength(20);


            builder.Property(t => t.Email)
                .HasMaxLength(50);

            builder.Property(t => t.Note)
               .HasMaxLength(500);
             
            builder.HasOne(t => t.Country)
                .WithMany(i=>i.InstitutionList).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(t => t.City)
                .WithMany(i => i.InstitutionList).OnDelete(DeleteBehavior.ClientSetNull);


            builder.Property(t => t.IsActive)
               .HasDefaultValue(true)
               .IsRequired();
        }
    }
}

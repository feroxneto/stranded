using CleanArchitecture.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Infrastructure.Persistence.Configurations
{
    class HealthStatusConfiguration : IEntityTypeConfiguration<HealthStatus>
    {
        public void Configure(EntityTypeBuilder<HealthStatus> builder)
        {
            builder.Property(t => t.Name)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(t => t.IsActive)
               .HasDefaultValue(true)
               .IsRequired();
        }
    }
}

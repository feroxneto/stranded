using CleanArchitecture.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Infrastructure.Persistence.Configurations
{
    class NotificationConfiguration : IEntityTypeConfiguration<Notification>
    {
        public void Configure(EntityTypeBuilder<Notification> builder)
        {
            builder.Property(t => t.Title)
                .HasMaxLength(70)
                .IsRequired();

            builder.Property(t => t.Message)
                .HasColumnType("text")
                .IsRequired();

            builder.Property(t => t.IsActive)
               .HasDefaultValue(true)
               .IsRequired();
        }
    }
}

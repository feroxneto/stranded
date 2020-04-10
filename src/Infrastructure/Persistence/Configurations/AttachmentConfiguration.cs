using CleanArchitecture.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Infrastructure.Persistence.Configurations
{
    class AttachmentConfiguration : IEntityTypeConfiguration<Attachment>
    {
        public void Configure(EntityTypeBuilder<Attachment> builder)
        {
            builder.Property(t => t.Description)
                .HasMaxLength(20)
                .IsRequired();

            builder.HasOne(t => t.Citizen)
            .WithMany(i => i.AttachmentList).OnDelete(DeleteBehavior.ClientCascade);
            
            builder.Property(e => e.Picture).HasColumnType("image");
        }
    }
}

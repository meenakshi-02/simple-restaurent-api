using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using restaurent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace restaurent.EntityConfiguration
{
    public class OrderMapping : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {     
            builder.Property(x => x.Quantity)
            .IsRequired();

            builder.Property(x => x.CreatedDateTime)
            .HasColumnType("nvarchar(10)")
            .IsRequired();

            builder.Property(x => x.servedDateTime)
            .HasColumnType("nvarchar(10)")
            .IsRequired();

            builder.Property(x => x.Price)
            .IsRequired();

            builder.Property(x => x.Status)
            .HasDefaultValue(false);

            builder.Property(x => x.ReadyToServe)
            .HasDefaultValue(false);

            builder.Property(x => x.IsActive)
            .HasDefaultValue(false);

            builder.HasOne(x => x.MenuItem)
            .WithMany(x => x.Orders)
            .HasForeignKey(x => x.FkMenuItemId);

            builder.ToTable("Orders", "reference");

        }
    }
}

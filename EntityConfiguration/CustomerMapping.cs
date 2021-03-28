using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using restaurent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace restaurent.EntityConfiguration
{
    public class CustomerMapping : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.Property(x => x.Name)
            .HasColumnType("nvarchar(100)")
            .IsRequired();

            builder.Property(x => x.Phone)
            .HasColumnType("nvarchar(12)")
            .IsRequired();

            builder.HasOne(x => x.Order)
              .WithOne(x => x.Customer)
              .HasForeignKey<Order>(x => x.FkCustomerId);

            builder.HasOne(x => x.Transaction)
              .WithOne(x => x.Customer)
              .HasForeignKey<Transaction>(x => x.FkCustomerId);

            builder.ToTable("Customers", "reference");
        }
    }

}

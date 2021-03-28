using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using restaurent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace restaurent.EntityConfiguration
{
    public class TransactionMapping : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
   
            builder.Property(x => x.Price)
            .IsRequired();

            builder.Property(x => x.DateTime)
            .HasColumnType("nvarchar(10)")
            .IsRequired();
        }
    }
}

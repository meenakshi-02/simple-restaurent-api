using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using restaurent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace restaurent.EntityConfiguration
{
    public class MenuItemMapping: IEntityTypeConfiguration<MenuItem>
    {
        public void Configure(EntityTypeBuilder<MenuItem> builder)
        {
            builder.Property(x => x.Name)
            .HasColumnType("nvarchar(100)")
            .IsRequired();

            builder.Property(x => x.Price)
            .IsRequired();

            /*builder.HasMany(x => x.Orders)
             .WithOne(x => x.MenuItem)
             .HasForeignKey<Order>(x => x.FkMenuItemId);*/

     

            builder.ToTable("MenuItems", "reference");
        }
    }
}

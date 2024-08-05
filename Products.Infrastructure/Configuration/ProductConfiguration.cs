using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Products.Core.Domain;

namespace Products.Infrastructure.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasOne(p => p.SubCategory)
                .WithMany(sc => sc.Products)
                .HasForeignKey(p => p.SubCategoryId);

            builder.HasOne(p => p.Size)
                .WithOne(s => s.Product)
                .HasForeignKey<SizeUnitOfMeasure>(p => p.ProductId);

            builder.HasOne(p=>p.Weight)
                .WithOne(w=>w.Product)
                .HasForeignKey<WeightUnitOfMeasure>(w => w.ProductId);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persons.Domain.Domain;

namespace Persons.Infrastructure.Configuration
{
    internal class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasMany(c => c.Address)
                .WithOne(a => a.Country)
                .HasForeignKey(a=>a.CountryId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}

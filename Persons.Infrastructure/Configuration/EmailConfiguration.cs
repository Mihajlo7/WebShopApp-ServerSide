﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persons.Domain.Domain;

namespace Persons.Infrastructure.Configuration
{
    public class EmailConfiguration : IEntityTypeConfiguration<EmailAddress>
    {
        public void Configure(EntityTypeBuilder<EmailAddress> builder)
        {
            builder.HasIndex(e => e.Email)
                .IsUnique();
        }
    }
}

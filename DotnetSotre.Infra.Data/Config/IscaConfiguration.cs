using DomainProject.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotnetSotre.Infra.Data.Config
{
    public class IscaConfiguration : IEntityTypeConfiguration<Isca>
    {
        public void Configure(EntityTypeBuilder<Isca> builder)
        {
            builder.HasKey(u => u.Id);
        }
    }
}

using DomainProject.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotnetSotre.Infra.Data.Config
{
    public class RoupaConfiguration : IEntityTypeConfiguration<Roupa>
    {
        public void Configure(EntityTypeBuilder<Roupa> builder)
        {
            builder.HasKey(r => r.Id);
            builder.HasOne(r => r.Animal);
        }
    }
}

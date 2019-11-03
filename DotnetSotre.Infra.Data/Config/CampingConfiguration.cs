using DomainProject.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotnetSotre.Infra.Data.Config
{
    public class CampingConfiguration : IEntityTypeConfiguration<Camping>
    {
        public void Configure(EntityTypeBuilder<Camping> builder)
        {
            builder.HasKey(c => c.Id);

        }
    }
}

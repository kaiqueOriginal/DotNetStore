using DomainProject.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotnetSotre.Infra.Data.Config
{
    public class ViveiroConfiguration : IEntityTypeConfiguration<Viveiro>
    {
        public void Configure(EntityTypeBuilder<Viveiro> builder)
        {
            builder.HasKey(v => v.Id);
            builder.HasOne(v => v.Animal);
        }
    }
}

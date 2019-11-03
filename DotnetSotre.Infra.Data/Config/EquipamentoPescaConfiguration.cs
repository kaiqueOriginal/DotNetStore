using DomainProject.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotnetSotre.Infra.Data.Config
{
    public class EquipamentoPescaConfiguration : IEntityTypeConfiguration<EquipamentoPesca>
    {
        public void Configure(EntityTypeBuilder<EquipamentoPesca> builder)
        {
            builder.HasKey(e => e.Id);
        }
    }
}

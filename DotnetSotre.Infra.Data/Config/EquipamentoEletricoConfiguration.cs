using DomainProject.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotnetSotre.Infra.Data.Config
{
    public class EquipamentoEletricoConfiguration : IEntityTypeConfiguration<EquipamentoEletrico>
    {
        public void Configure(EntityTypeBuilder<EquipamentoEletrico> builder)
        {
            builder.HasKey(u => u.Id);
        }
    }
}

using DomainProject.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotnetSotre.Infra.Data.Config
{
    public class VaraConfiguration : IEntityTypeConfiguration<Vara>
    {
        public void Configure(EntityTypeBuilder<Vara> builder)
        {
            builder.HasKey(v => v.Id);
            builder.Property(v => v.Descricao).IsRequired().HasMaxLength(400);
            builder.Property(v => v.Acao);
            builder.Property(v => v.Fabricante).IsRequired().HasMaxLength(80);
            builder.Property(v => v.Fotos).IsRequired().HasMaxLength(150);
        }
    }
}

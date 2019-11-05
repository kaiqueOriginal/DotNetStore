using DomainProject.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotnetSotre.Infra.Data.Config
{
    public class DecoracaoConfiguration : IEntityTypeConfiguration<Decoracao>
    {
        public void Configure(EntityTypeBuilder<Decoracao> builder)
        {
            builder.HasOne(d => d.Animal);
        }
    }
}

using DomainProject.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotnetSotre.Infra.Data.Config
{
    public class RemedioCondiguration : IEntityTypeConfiguration<Remedio>
    {
        public void Configure(EntityTypeBuilder<Remedio> builder)
        {
            builder.HasKey(r => r.Id);
        }
    }
}

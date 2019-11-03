using DomainProject.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotnetSotre.Infra.Data.Config
{
    public class LocalConfiguration : IEntityTypeConfiguration<Local>
    {
        public void Configure(EntityTypeBuilder<Local> builder)
        {
            builder.HasKey(u => u.Id);
        }
    }
}

using DomainProject.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotnetSotre.Infra.Data.Config
{
    public class ProdutoHigieneConfiguration : IEntityTypeConfiguration<ProdutoHigiene>
    {
        public void Configure(EntityTypeBuilder<ProdutoHigiene> builder)
        {
            builder.HasKey(p => p.Id);
        }
    }
}

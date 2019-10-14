using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using DomainProject.Entities.Models;

namespace DotnetSotre.Infra.Data.Context
{
    public class StoreContext : DbContext
    {
        public DbSet<Animal> Animais { get; set; }
        public DbSet<Vara> Varas { get; set; }



        public StoreContext(DbContextOptions options) : base(options)
        {
            
        }
    }
}

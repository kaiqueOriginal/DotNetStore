using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using DomainProject.Entities.Models;
using DotnetSotre.Infra.Data.Config;
using DomainProject.Entities;

namespace DotnetSotre.Infra.Data.Context
{
    public class StoreContext : DbContext
    {
        #region DbSets
        public DbSet<Animal> Animais { get; set; }
        public DbSet<Camping> Camping { get; set; }
        public DbSet<Decoracao> Decoracao { get; set; }
        public DbSet<EquipamentoEletrico> EquipamentosEletricos { get; set; }
        public DbSet<EquipamentoPesca> EquipamentosPesca { get; set; }
        public DbSet<Estoque> Estoques { get; set; }
        public DbSet<Isca> Iscas { get; set; }
        public DbSet<Local> Locais { get; set; }
        public DbSet<Manutencao> Manutencao { get; set; }
        public DbSet<ProdutoHigiene> ProdutosHigiene { get; set; }
        public DbSet<Racao> Racoes { get; set; }
        public DbSet<Remedio> Remedios { get; set; }
        public DbSet<Roupa> Roupas { get; set; }
        public DbSet<Vara> Varas { get; set; }
        public DbSet<Viveiro> Viveiros { get; set; }
        #endregion

        public StoreContext(DbContextOptions options) : base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AnimalConfiguration());
            modelBuilder.ApplyConfiguration(new CampingConfiguration());
            modelBuilder.ApplyConfiguration(new DecoracaoConfiguration());
            modelBuilder.ApplyConfiguration(new EquipamentoEletricoConfiguration());
            modelBuilder.ApplyConfiguration(new EquipamentoPescaConfiguration());
            modelBuilder.ApplyConfiguration(new EstoqueConfiguration());
            modelBuilder.ApplyConfiguration(new IscaConfiguration());
            modelBuilder.ApplyConfiguration(new LocalConfiguration());
            modelBuilder.ApplyConfiguration(new ManutencaoConfiguration());
            modelBuilder.ApplyConfiguration(new ProdutoHigieneConfiguration());
            modelBuilder.ApplyConfiguration(new RacaoConfiguration());
            modelBuilder.ApplyConfiguration(new RemedioCondiguration());
            modelBuilder.ApplyConfiguration(new RoupaConfiguration());
            modelBuilder.ApplyConfiguration(new VaraConfiguration());
            modelBuilder.ApplyConfiguration(new ViveiroConfiguration());
            base.OnModelCreating(modelBuilder);
        }


    }
}

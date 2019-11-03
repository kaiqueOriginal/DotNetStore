﻿// <auto-generated />
using System;
using DotnetSotre.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DotnetSotre.Infra.Data.Migrations
{
    [DbContext(typeof(StoreContext))]
    [Migration("20191018030412_PrimeiraClasseConfigurada2")]
    partial class PrimeiraClasseConfigurada2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("DomainProject.Entities.Models.Animal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Especie")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue("100");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Animais");
                });

            modelBuilder.Entity("DomainProject.Entities.Models.Vara", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Acao");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(400);

                    b.Property<string>("Fabricante")
                        .IsRequired()
                        .HasMaxLength(80);

                    b.Property<string>("Fotos")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<DateTime>("Insercao");

                    b.Property<int>("Libragem");

                    b.Property<int>("Passadores");

                    b.Property<float>("Peso");

                    b.Property<double>("Preco");

                    b.Property<DateTime>("StampDateTime");

                    b.Property<float>("Tamanho");

                    b.Property<int>("Tipo");

                    b.Property<bool>("isInteirica");

                    b.HasKey("Id");

                    b.ToTable("Varas");
                });
#pragma warning restore 612, 618
        }
    }
}

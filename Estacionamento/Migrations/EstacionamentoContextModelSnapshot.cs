﻿// <auto-generated />
using System;
using Estacionamento.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Estacionamento.Migrations
{
    [DbContext(typeof(EstacionamentoContext))]
    partial class EstacionamentoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Estacionamento.Models.Carro", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cor");

                    b.Property<string>("Marca");

                    b.Property<string>("Placa");

                    b.HasKey("id");

                    b.ToTable("Carro");
                });

            modelBuilder.Entity("Estacionamento.Models.Vaga", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Carroid");

                    b.Property<DateTime>("Inicio");

                    b.Property<DateTime?>("Termino");

                    b.Property<int>("idCarro");

                    b.HasKey("id");

                    b.HasIndex("Carroid");

                    b.ToTable("Vaga");
                });

            modelBuilder.Entity("Estacionamento.Models.Vaga", b =>
                {
                    b.HasOne("Estacionamento.Models.Carro", "Carro")
                        .WithMany()
                        .HasForeignKey("Carroid");
                });
#pragma warning restore 612, 618
        }
    }
}

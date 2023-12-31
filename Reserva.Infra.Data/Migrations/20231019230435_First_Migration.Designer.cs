﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Reserva.Infra.Data.Context;

#nullable disable

namespace Reserva.Infra.Data.Migrations
{
    [DbContext(typeof(ReservaContext))]
    [Migration("20231019230435_First_Migration")]
    partial class First_Migration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Reserva.Domain.Entities.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("Varchar(100)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("Varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Cliente", (string)null);
                });

            modelBuilder.Entity("Reserva.Domain.Entities.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("Varchar(50)");

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasColumnType("Varchar(8)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LojaId")
                        .HasColumnType("int");

                    b.Property<int>("Numero")
                        .HasColumnType("INT");

                    b.Property<string>("Rua")
                        .IsRequired()
                        .HasColumnType("Varchar(150)");

                    b.HasKey("Id");

                    b.ToTable("Endereco", (string)null);
                });

            modelBuilder.Entity("Reserva.Domain.Entities.Loja", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("EnderecoId")
                        .HasColumnType("INT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("Varchar(100)");

                    b.Property<int>("RedeRestauranteId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EnderecoId")
                        .IsUnique();

                    b.HasIndex("RedeRestauranteId");

                    b.ToTable("Loja", (string)null);
                });

            modelBuilder.Entity("Reserva.Domain.Entities.RedeRestaurante", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("LojaId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("Varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("RedeRestaurante", (string)null);
                });

            modelBuilder.Entity("Reserva.Domain.Entities.Reserva", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Capacidade")
                        .HasColumnType("INT");

                    b.Property<int>("ClienteId")
                        .HasColumnType("INT");

                    b.Property<DateTime>("Horario")
                        .HasColumnType("datetime2");

                    b.Property<int>("LojaId")
                        .HasColumnType("INT");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId")
                        .IsUnique();

                    b.HasIndex("LojaId");

                    b.ToTable("Reserva", (string)null);
                });

            modelBuilder.Entity("Reserva.Domain.Entities.Loja", b =>
                {
                    b.HasOne("Reserva.Domain.Entities.Endereco", "Endereco")
                        .WithOne("Loja")
                        .HasForeignKey("Reserva.Domain.Entities.Loja", "EnderecoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Reserva.Domain.Entities.RedeRestaurante", "RedeRestaurante")
                        .WithMany("Lojas")
                        .HasForeignKey("RedeRestauranteId")
                        .HasPrincipalKey("LojaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Endereco");

                    b.Navigation("RedeRestaurante");
                });

            modelBuilder.Entity("Reserva.Domain.Entities.Reserva", b =>
                {
                    b.HasOne("Reserva.Domain.Entities.Cliente", "Cliente")
                        .WithOne("Reserva")
                        .HasForeignKey("Reserva.Domain.Entities.Reserva", "ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Reserva.Domain.Entities.Loja", "Loja")
                        .WithMany()
                        .HasForeignKey("LojaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Loja");
                });

            modelBuilder.Entity("Reserva.Domain.Entities.Cliente", b =>
                {
                    b.Navigation("Reserva")
                        .IsRequired();
                });

            modelBuilder.Entity("Reserva.Domain.Entities.Endereco", b =>
                {
                    b.Navigation("Loja")
                        .IsRequired();
                });

            modelBuilder.Entity("Reserva.Domain.Entities.RedeRestaurante", b =>
                {
                    b.Navigation("Lojas");
                });
#pragma warning restore 612, 618
        }
    }
}

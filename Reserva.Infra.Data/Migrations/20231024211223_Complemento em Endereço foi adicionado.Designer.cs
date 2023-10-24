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
    [Migration("20231024211223_Complemento em Endereço foi adicionado")]
    partial class ComplementoemEndereçofoiadicionado
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

            modelBuilder.Entity("Reserva.Domain.Entities.Loja", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CapacidadeTotal")
                        .HasColumnType("int");

                    b.Property<int>("EnderecoId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("Varchar(100)");

                    b.Property<int>("RedeRestauranteId")
                        .HasColumnType("int");

                    b.HasKey("Id");

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

                    b.Property<int>("ClienteId")
                        .HasColumnType("INT");

                    b.Property<DateTime>("Horario")
                        .HasColumnType("datetime2");

                    b.Property<int>("LojaId")
                        .HasColumnType("INT");

                    b.Property<int>("QTDReserva")
                        .HasColumnType("INT");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId")
                        .IsUnique();

                    b.HasIndex("LojaId");

                    b.ToTable("Reserva", (string)null);
                });

            modelBuilder.Entity("Reserva.Domain.Entities.Loja", b =>
                {
                    b.HasOne("Reserva.Domain.Entities.RedeRestaurante", "RedeRestaurante")
                        .WithMany("Lojas")
                        .HasForeignKey("RedeRestauranteId")
                        .HasPrincipalKey("LojaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("Reserva.Domain.Entities.Endereco", "Endereco", b1 =>
                        {
                            b1.Property<int>("LojaId")
                                .HasColumnType("INT");

                            b1.Property<string>("Bairro")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("Bairro");

                            b1.Property<string>("CEP")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("CEP");

                            b1.Property<string>("Cidade")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("Cidade");

                            b1.Property<string>("Complemento")
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("Complemento");

                            b1.Property<int>("Numero")
                                .HasColumnType("int")
                                .HasColumnName("Numero");

                            b1.Property<string>("Rua")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("Rua");

                            b1.HasKey("LojaId");

                            b1.ToTable("Loja");

                            b1.WithOwner()
                                .HasForeignKey("LojaId");
                        });

                    b.Navigation("Endereco")
                        .IsRequired();

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

            modelBuilder.Entity("Reserva.Domain.Entities.RedeRestaurante", b =>
                {
                    b.Navigation("Lojas");
                });
#pragma warning restore 612, 618
        }
    }
}

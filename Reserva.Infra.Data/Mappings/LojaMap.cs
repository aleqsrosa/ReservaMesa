using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Reserva.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Infra.Data.Mappings
{
    public class LojaMap : IEntityTypeConfiguration<Loja>
    {
        public void Configure(EntityTypeBuilder<Loja> builder)
        {
            builder.ToTable("Loja");
            builder.HasKey(l => l.Id);
            builder.Property(l => l.Id)
            .HasColumnType("INT").UseIdentityColumn();

            builder.Property(l => l.Nome)
                .HasColumnType("Varchar(100)")
                .IsRequired();

            builder.OwnsOne(l => l.Endereco)
                .Property(l => l.Numero)
                .HasColumnName("Numero")
                .IsRequired(true);

            builder.OwnsOne(l => l.Endereco)
                .Property(l => l.Bairro)
                .HasColumnName("Bairro")
                .IsRequired(true);

            builder.OwnsOne(l => l.Endereco)
                .Property(l => l.CEP)
                .HasColumnName("CEP")
                .IsRequired(true);

            builder.OwnsOne(l => l.Endereco)
                .Property(l => l.Cidade)
                .HasColumnName("Cidade")
                .IsRequired(true);

            builder.OwnsOne(l => l.Endereco)
                .Property(l => l.Rua)
                .HasColumnName("Rua")
                .IsRequired(true);

            builder.OwnsOne(l => l.Endereco)
                .Property(l => l.Complemento)
                .HasColumnName("Complemento")
                .IsRequired(false);

            builder.HasOne(l => l.RedeRestaurante)
                .WithMany(r => r.Lojas)
                .HasForeignKey(r => r.RedeRestauranteId);
        }
    }
}

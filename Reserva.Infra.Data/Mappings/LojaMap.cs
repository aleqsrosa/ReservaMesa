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

            builder.HasOne(l => l.Endereco)
                .WithOne(e => e.Loja)
                .HasForeignKey<Loja>(l => l.EnderecoId);

            builder.HasOne(l => l.RedeRestaurante)
                .WithMany(r => r.Lojas)
                .HasForeignKey(r => r.RedeRestauranteId);
        }
    }
}

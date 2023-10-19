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
    public class EnderecoMap : IEntityTypeConfiguration<Endereco>
    {     
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.ToTable("Endereco");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id)
            .HasColumnType("INT").UseIdentityColumn();
            builder.Property(e => e.Rua)
                .HasColumnType("Varchar(150)");
            builder.Property(e => e.Bairro)
                .HasColumnType("Varchar(50)");
            builder.Property(e => e.Numero)
                .HasColumnType("INT");
            builder.Property(e => e.CEP)
                .HasColumnType("Varchar(8)");
        }
    }
}

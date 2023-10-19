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
    public class ReservaMap : IEntityTypeConfiguration<Domain.Entities.Reserva>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.Reserva> builder)
        {
            builder.ToTable("Reserva");
            builder.HasKey(r => r.Id);
            builder.Property(r => r.Id)
            .HasColumnType("INT").UseIdentityColumn();

            builder.Property(r => r.Capacidade)
                .HasColumnType("INT");

            builder.HasOne(r => r.Cliente)
               .WithOne(c => c.Reserva)
               .HasForeignKey<Domain.Entities.Reserva>(c => c.ClienteId);

        }
    }
}

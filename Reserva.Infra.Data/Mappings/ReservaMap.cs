using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
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
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id)
            .HasColumnType("INT").UseIdentityColumn();
        }
    }
}

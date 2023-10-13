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
    public class RedeRestauranteMap : IEntityTypeConfiguration<RedeRestaurante>
    {
        public void Configure(EntityTypeBuilder<RedeRestaurante> builder)
        {
            builder.ToTable("RedeRestaurante");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id)
            .HasColumnType("INT").UseIdentityColumn();
        }
    }
}

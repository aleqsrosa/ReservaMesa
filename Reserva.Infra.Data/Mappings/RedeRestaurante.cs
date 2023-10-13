using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Infra.Data.Mappings
{
    public class RedeRestaurante : IEntityTypeConfiguration<RedeRestaurante>
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

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Reserva.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Infra.Data.Context
{
    public class ReservaContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public ReservaContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Loja> Loja { get; set; }
        public DbSet<Domain.Entities.Reserva> Reserva { get; set; }
        public DbSet<RedeRestaurante> RedeRestaurante { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("ReservaDb"));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ReservaContext).Assembly);
        }
    }
}

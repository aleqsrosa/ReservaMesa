using Microsoft.Extensions.DependencyInjection;
using Reserva.Application.Interfaces;
using Reserva.Application.Services;
using Reserva.Domain.Entities;
using Reserva.Domain.Interface;
using Reserva.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Infra.IoC
{
    public class NativeInjector
    {
        public static void RegisterServices(IServiceCollection services)
        {
            #region Services

            services.AddScoped<IClienteAppService, ClienteAppService>();
            services.AddScoped<IReservaAppService, ReservaAppService>();
            services.AddScoped<IRedeRestauranteRepository, RedeRestauranteRepository>();

            #endregion

            #region Repositories

            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IReservaRepository, ReservaRepository>();
            services.AddScoped<IRedeRestauranteRepository, RedeRestauranteRepository>();

            #endregion
        }
    }
}

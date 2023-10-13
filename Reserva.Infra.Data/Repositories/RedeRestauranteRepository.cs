﻿using Reserva.Domain.Entities;
using Reserva.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Infra.Data.Repositories
{
    public class RedeRestauranteRepository : Repository<RedeRestaurante>
    {
        public RedeRestauranteRepository(ReservaContext context) : base(context)
        {
        }
    }
}

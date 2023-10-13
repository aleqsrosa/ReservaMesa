﻿using Reserva.Domain.Entities;
using Reserva.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Infra.Data.Repositories
{
    public class LojaRepository : Repository<Loja>
    {
        public LojaRepository(ReservaContext context) : base(context)
        {
        }
    }
}

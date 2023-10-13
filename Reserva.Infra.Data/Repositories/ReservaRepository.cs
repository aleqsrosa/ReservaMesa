using Reserva.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Infra.Data.Repositories
{
    public class ReservaRepository : Repository<Domain.Entities.Reserva>
    {
        public ReservaRepository(ReservaContext context) : base(context)
        {
        }
    }
}

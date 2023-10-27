using Reserva.Application.DTO.Cliente;
using Reserva.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Application.Interfaces
{
    public interface IClienteAppService : IAppService<ClienteDTO>
    {
    }
}

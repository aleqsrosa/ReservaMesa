using Reserva.Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Application.Interfaces
{
    public interface IClienteAppService
    {
        List<ClienteDTO> Get();
        bool Post(ClienteDTO clienteDTO);
        ClienteDTO GetById(int id);
        bool Put(ClienteDTO clienteDTO);
        bool Delete(int id);
    }
}

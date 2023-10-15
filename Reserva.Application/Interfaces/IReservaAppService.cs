using Reserva.Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Application.Interfaces
{
    public interface IReservaAppService
    {
        List<ReservaDTO> GetAll();
        void Post(ReservaDTO clienteDTO);
        ReservaDTO GetById(int id);
        void Put(ReservaDTO clienteDTO);
        void Delete(int id);
    }
}

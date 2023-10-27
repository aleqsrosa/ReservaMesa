using Reserva.Application.DTO.RedeRestaurante;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Application.Interfaces
{
    public interface IRedeRestauranteAppService
    {
        List<RedeRestauranteDTO> GetAll();
        void Post(RedeRestauranteDTO clienteDTO);
        RedeRestauranteDTO GetById(int id);
        void Put(RedeRestauranteDTO clienteDTO);
        void Delete(int id);
    }
}

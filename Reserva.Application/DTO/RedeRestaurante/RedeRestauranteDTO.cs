using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Application.DTO.RedeRestaurante
{
    public class RedeRestauranteDTO : BaseDTO
    {
        public string Nome { get; set; }

        public RedeRestauranteDTO()
        {

        }

        public RedeRestauranteDTO(CadastrarRedeRestauranteDTO cadastrarRedeRestauranteDTO)
        {
            Nome = cadastrarRedeRestauranteDTO.Nome;
        }
    }
}

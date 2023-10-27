using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Application.DTO.Loja
{
    public class CadastrarLojaDTO
    {
        public string Nome { get; set; }
        public EnderecoDTO Endereco { get; set; }
        public int RedeRestauranteId { get; set; }
        public int CapacidadeTotal { get; set; }

    }
}

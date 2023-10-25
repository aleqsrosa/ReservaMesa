using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Application.DTO
{
    public class LojaDTO : BaseDTO
    {
        public string Nome { get; set; }
        public EnderecoDTO Endereco { get; set; }
        public int RedeRestauranteId { get; set; }
        public List<ReservaDTO> Reservas { get; set; }  
    }
}

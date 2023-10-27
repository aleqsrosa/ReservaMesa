using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Application.DTO
{
    public class EnderecoDTO 
    {
        public EnderecoDTO()
        {
        }

        public string Rua { get; set; }
        public string Bairro { get; set; }
        public int Numero { get; set; }
        public string Cidade { get; set; }
        public string CEP { get; set; }
        public string? Complemento { get; set; }
    }
}

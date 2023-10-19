using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reserva.Domain.Models;

namespace Reserva.Domain.Entities
{
    public class Loja : Entity
    {
        public string Nome { get; set; }
        public Endereco Endereco { get; set; }
        public RedeRestaurante RedeRestaurante { get; set; }
        public int RedeRestauranteId { get; set; }
        public int EnderecoId { get; set; }

    }
}

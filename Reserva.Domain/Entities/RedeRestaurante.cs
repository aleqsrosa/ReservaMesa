using Reserva.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Domain.Entities
{
    public class RedeRestaurante : Entity
    {
        public string Nome { get; set; }
        public ICollection<Loja> Lojas { get; set; }
    }
}

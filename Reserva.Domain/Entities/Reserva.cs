using Reserva.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Domain.Entities
{
    public class Reserva : Entity
    {
        public Cliente Cliente { get; set; }
        public Loja Loja { get; set; }
        public DateTime Horario { get; set; }

    }
}

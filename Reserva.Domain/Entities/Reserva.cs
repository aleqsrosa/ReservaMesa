using Reserva.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Domain.Entities
{
    public class Reserva : Entity
    {
        public Cliente Cliente { get; set; }
        public Loja Loja { get; set; }
        public DateTime Horario { get; set; }
        public int Capacidade { get; set; }
        public int ClienteId { get; set; }

    }
}

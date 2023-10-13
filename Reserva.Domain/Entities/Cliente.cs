using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reserva.Domain.Models;

namespace Reserva.Domain.Entities
{
    public class Cliente : Entity
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
    }
}

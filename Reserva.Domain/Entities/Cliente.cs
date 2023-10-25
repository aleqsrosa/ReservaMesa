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
        public string Nome { get; private set; }
        public string Telefone { get; private set; }
        public virtual ICollection<Reserva> Reservas { get; set; }

        protected Cliente() { }

        public Cliente(string nome, string telefone)
        {
            Nome = nome;
            Telefone = telefone;
        }
    }

}
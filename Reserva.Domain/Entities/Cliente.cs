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
        public Reserva Reserva { get; private set; }

        private List<Reserva> reservas = new List<Reserva>();

        public IReadOnlyCollection<Reserva> Reservas => reservas.AsReadOnly();

        public Cliente(string nome, string telefone)
        {
            if (string.IsNullOrEmpty(nome))
            {
                throw new InvalidOperationException("O nome do cliente é obrigatório.");
            }

            if (string.IsNullOrEmpty(telefone))
            {
                throw new InvalidOperationException("O telefone do cliente é obrigatório.");
            }

            Nome = nome;
            Telefone = telefone;
        }

        public Reserva FazerReserva(Loja loja, DateTime horario, int qtdReserva)
        {
            if (horario < DateTime.Now)
            {
                throw new InvalidOperationException("Não é possível fazer reservas para horários passados.");
            }

            if (qtdReserva <= 0)
            {
                throw new InvalidOperationException("A quantidade da reserva deve ser maior que zero.");
            }

            if (reservas.Any(r => r.Horario == horario))
            {
                throw new InvalidOperationException("Já existe uma reserva para este horário.");
            }

            var reserva = new Reserva(this, loja, horario, qtdReserva);
            reservas.Add(reserva);
            return reserva;
        }

        public void CancelarReserva(Reserva reserva)
        {
            if (reserva == null)
            {
                throw new ArgumentNullException(nameof(reserva));
            }

            if (reservas.Contains(reserva))
            {
                reservas.Remove(reserva);
            }
        }
    }

}
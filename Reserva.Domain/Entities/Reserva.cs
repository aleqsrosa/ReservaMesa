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
        public Cliente Cliente { get; private set; }
        public Loja Loja { get; private set; }
        public DateTime Horario { get; private set; }
        public int QTDReserva { get; private set; }
        public int ClienteId { get; private set; }
        public int LojaId { get; private set; }

        protected Reserva() { }

        // Construtor para criar uma nova reserva
        public Reserva(Cliente cliente, Loja loja, DateTime horario, int qtdReserva)
        {
            if (horario < DateTime.Now)
            {
                throw new InvalidOperationException("Não é possível fazer reservas para horários passados.");
            }

            if (qtdReserva <= 0)
            {
                throw new InvalidOperationException("A quantidade da reserva deve ser maior que zero.");
            }

            Cliente = cliente ?? throw new ArgumentNullException(nameof(cliente));
            Loja = loja ?? throw new ArgumentNullException(nameof(loja));
            Horario = horario;
            QTDReserva = qtdReserva;
            ClienteId = cliente.Id;
            LojaId = loja.Id;

            if (Loja.CapacidadeMaximaDisponivel() > Loja.CapacidadeTotal)
            {
                throw new InvalidOperationException("MUDARTEXTO");
            }
        }

        // Método para atualizar a quantidade da reserva
        public void AtualizarQuantidade(int novaQTDReserva)
        {
            if (novaQTDReserva <= 0)
            {
                throw new InvalidOperationException("A nova quantidade de reserva deve ser maior que zero.");
            }

            if (novaQTDReserva > Loja.CapacidadeTotal)
            {
                throw new InvalidOperationException("A nova quantidade de reserva não pode ser maior que a capacidade máxima permitida pela loja.");
            }

            QTDReserva = novaQTDReserva;
        }

        // Método para atualizar o horário da reserva
        public void AtualizarHorario(DateTime novoHorario)
        {
            if (Horario >= novoHorario)
            {
                throw new InvalidOperationException("Horário precisa ser maior que o anterior.");
            }

            Horario = novoHorario;
        }
    }

}

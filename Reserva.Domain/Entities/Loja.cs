using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reserva.Domain.Enums;
using Reserva.Domain.Models;

namespace Reserva.Domain.Entities
{
    public class Loja : Entity
    {
        public Loja()
        {
            
        }
        public Loja(string nome, Endereco endereco, int redeRestauranteId, int capacidadeTotal)
        {
            Nome = nome;
            Endereco = new Endereco(endereco.Rua, endereco.Bairro, endereco.Numero, endereco.Cidade, endereco.CEP, endereco.Complemento);
            RedeRestauranteId = redeRestauranteId;
            CapacidadeTotal = capacidadeTotal;
        }
        public string Nome { get; private set; }
        public Endereco Endereco { get; private set; }
        public RedeRestaurante RedeRestaurante { get; private set; }
        public int RedeRestauranteId { get; private set; }
        public int CapacidadeTotal { get; set; }
        public virtual ICollection<Reserva> Reservas { get; set; }

        public bool VerificarLimiteReservasPorDia(DateTime dataDaReserva, TurnoEnum turno, int qtdReserva)
        {
            var reservasNoDia = Reservas.Where(r => r.Data.Date == dataDaReserva.Date && r.Turno == turno).Sum(x => x.QTDReserva);

            return CapacidadeTotal - reservasNoDia >= qtdReserva;
        }

    }
}

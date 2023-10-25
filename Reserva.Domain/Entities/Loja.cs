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
        public Loja()
        {
            
        }
        public Loja(string nome, Endereco endereco, RedeRestaurante redeRestaurante, int capacidadeTotal)
        {
            Nome = nome;
            Endereco = new Endereco(endereco.Rua, endereco.Bairro, endereco.Numero, endereco.Cidade, endereco.CEP);
            RedeRestaurante = redeRestaurante;
            CapacidadeTotal = capacidadeTotal;
        }
        public string Nome { get; private set; }
        public Endereco Endereco { get; private set; }
        public RedeRestaurante RedeRestaurante { get; private set; }
        public int RedeRestauranteId { get; private set; }
        public int CapacidadeTotal { get; set; }
        public int EnderecoId { get; private set; }
        public virtual ICollection<Reserva> Reservas { get; set; }

        public int CapacidadeMaximaDisponivel()
        {
            return 0; //Reservas.Sum(x => x.QTDReserva);
        }

    }
}

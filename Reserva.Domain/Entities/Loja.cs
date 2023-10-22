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

        public string Nome { get; set; }
        public Endereco Endereco { get; set; }
        public RedeRestaurante RedeRestaurante { get; set; }
        public int RedeRestauranteId { get; set; }
        public int CapacidadeTotal { get; set; }
        public int EnderecoId { get; set; }

    }
}

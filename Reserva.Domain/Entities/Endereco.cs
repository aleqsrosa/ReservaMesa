using Reserva.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Domain.Entities
{
    public class Endereco
    {
        public Endereco(string rua, string bairro, int numero, string cidade, string cEP, string? complemento = null)
        {
            Rua = rua;
            Bairro = bairro;
            Numero = numero;
            Cidade = cidade;
            CEP = cEP;
            Complemento = complemento;
        }

        public string Rua { get; private set; }
        public string? Complemento { get; private set; }
        public string Bairro { get; private set; }
        public int Numero { get; private set; }
        public string Cidade { get; private set; }
        public string CEP { get; private set; }
    }
}

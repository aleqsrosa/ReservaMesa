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
        public Endereco(string rua, string bairro, int numero, string cidade, string cEP)
        {
            Rua = rua;
            Bairro = bairro;
            Numero = numero;
            Cidade = cidade;
            CEP = cEP;
        }

        public string Rua { get; set; }
        public string Bairro { get; set; }
        public int Numero { get; set; }
        public string Cidade { get; set; }
        public string CEP { get; set; }
    }
}

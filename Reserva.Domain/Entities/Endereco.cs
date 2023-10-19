﻿using Reserva.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Domain.Entities
{
    public class Endereco : Entity
    {
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public int Numero { get; set; }
        public string Cidade { get; set; }
        public string CEP { get; set; }
        public Loja Loja { get; set; }
        public int LojaId { get; set; }
    }
}

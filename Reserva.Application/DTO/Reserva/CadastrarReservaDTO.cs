using Reserva.Application.DTO.Cliente;
using Reserva.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Application.DTO.Reserva
{
    public class CadastrarReservaDTO 
    {
        public int ClienteId { get; set; }
        public int LojaId { get; set; }
        public DateTime Data { get; set; }
        public int QtdReserva { get; set; }
        public TurnoEnum Turno { get; set; }
    }
}

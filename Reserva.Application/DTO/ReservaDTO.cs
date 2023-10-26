using Reserva.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Application.DTO
{
    public class ReservaDTO :  BaseDTO
    {
        public int ClienteId { get; set; }
        public int LojaId { get; set; }
        public DateTime Data { get; set; }
        public int QtdReserva { get; set; }
        public TurnoEnum Turno { get; set; }
        public ClienteDTO Cliente { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Application.DTO
{
    public class ReservaDTO :  BaseDTO
    {
        public ClienteDTO Cliente { get; set; }
        public int ClienteId { get; set; }
        public int LojaId { get; set; }
        public LojaDTO Loja { get; set; }
        public DateTime Horario { get; set; }
        public int QtdReserva { get; set; }
    }
}

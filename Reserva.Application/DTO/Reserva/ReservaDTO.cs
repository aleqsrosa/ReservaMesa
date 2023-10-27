using Reserva.Application.DTO.Cliente;
using Reserva.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Application.DTO.Reserva
{
    public class ReservaDTO : BaseDTO
    {

        public int ClienteId { get; set; }
        public int LojaId { get; set; }
        public DateTime Data { get; set; }
        public int QtdReserva { get; set; }
        public TurnoEnum Turno { get; set; }
        public ClienteDTO Cliente { get; set; }
        public ReservaDTO()
        {
            
        }
        public ReservaDTO(CadastrarReservaDTO cadastrarReservaDTO)
        {
            ClienteId = cadastrarReservaDTO.ClienteId;
            LojaId = cadastrarReservaDTO.LojaId;
            Data = cadastrarReservaDTO.Data;
            QtdReserva = cadastrarReservaDTO.QtdReserva;
            Turno = cadastrarReservaDTO.Turno;
        }
        public ReservaDTO(AtualizarReservaDTO atualizarReservaDTO)
        {
            Id = atualizarReservaDTO.Id;
            Data = atualizarReservaDTO.Data;
            QtdReserva = atualizarReservaDTO.QtdReserva;
            Turno = atualizarReservaDTO.Turno;
        }
    }
}

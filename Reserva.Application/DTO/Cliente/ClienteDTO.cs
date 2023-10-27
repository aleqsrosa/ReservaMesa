using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Application.DTO.Cliente
{
    public class ClienteDTO : BaseDTO
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }

        public ClienteDTO()
        {
                
        }

        public ClienteDTO(CadastrarClienteDTO clienteDTO)
        {
            Nome = clienteDTO.Nome;
            Telefone = clienteDTO.Telefone;
        }
    }
}

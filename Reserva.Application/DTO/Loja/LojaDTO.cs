using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Application.DTO.Loja
{
    public class LojaDTO : BaseDTO
    {
        public string Nome { get; set; }
        public EnderecoDTO Endereco { get; set; }
        public int RedeRestauranteId { get; set; }
        public IReadOnlyCollection<ReservaDTO> Reservas { get; set; }
        public int CapacidadeTotal { get; set; }

        public LojaDTO()
        {

        }

        public LojaDTO(CadastrarLojaDTO cadastrarLojaDTO)
        {
            Nome = cadastrarLojaDTO.Nome;
            RedeRestauranteId = cadastrarLojaDTO.RedeRestauranteId;
            CapacidadeTotal = cadastrarLojaDTO.CapacidadeTotal;
            Endereco = new EnderecoDTO()
            {
                Numero = cadastrarLojaDTO.Endereco.Numero,
                CEP = cadastrarLojaDTO.Endereco.CEP,
                Complemento = cadastrarLojaDTO.Endereco.Complemento,
                Cidade = cadastrarLojaDTO.Endereco.Cidade,
                Rua = cadastrarLojaDTO.Endereco.Rua,
                Bairro = cadastrarLojaDTO.Endereco.Bairro
            };
        }
    }
}

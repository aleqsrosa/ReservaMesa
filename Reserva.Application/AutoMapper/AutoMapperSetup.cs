using AutoMapper;
using Reserva.Application.DTO;
using Reserva.Application.DTO.Cliente;
using Reserva.Application.DTO.Loja;
using Reserva.Application.DTO.RedeRestaurante;
using Reserva.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Application.AutoMapper
{
    public class AutoMapperSetup : Profile
    {
        public AutoMapperSetup()
        {
            #region ViewModelToDomain
            //Cliente
            CreateMap<ClienteDTO, Cliente>();

            //Loja
            CreateMap<LojaDTO, Loja>();
            
            //RedeRestaurante
            CreateMap<RedeRestauranteDTO, RedeRestaurante>();
            //Reserva
            CreateMap<ReservaDTO, Domain.Entities.Reserva>();

            //Endereco
            CreateMap<EnderecoDTO, Endereco>();

            #endregion

            #region DomainToViewModel

            CreateMap<Loja, LojaDTO>();
            CreateMap<Endereco, EnderecoDTO>();
            CreateMap<RedeRestaurante, RedeRestauranteDTO>();
            CreateMap<Domain.Entities.Reserva, ReservaDTO>();
            CreateMap<Cliente, ClienteDTO>();

            #endregion
        }
    }
}

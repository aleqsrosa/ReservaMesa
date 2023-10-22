using AutoMapper;
using Reserva.Application.DTO;
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

            CreateMap<ClienteDTO, Cliente>();
            CreateMap<LojaDTO, Loja>(); 
            CreateMap<RedeRestauranteDTO, RedeRestaurante>();
            CreateMap<ReservaDTO, Domain.Entities.Reserva>();
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

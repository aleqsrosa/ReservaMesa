﻿using AutoMapper;
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

            CreateMap<ReservaDTO, Cliente>();
            CreateMap<ReservaDTO, Loja>(); 
            CreateMap<ReservaDTO, RedeRestaurante>();
            CreateMap<ReservaDTO, Domain.Entities.Reserva>();

            #endregion

            #region DomainToViewModel

            CreateMap<Loja, ReservaDTO>();
            CreateMap<RedeRestaurante, ReservaDTO>();
            CreateMap<Domain.Entities.Reserva, ReservaDTO>();
            CreateMap<Cliente, ReservaDTO>();

            #endregion
        }
    }
}

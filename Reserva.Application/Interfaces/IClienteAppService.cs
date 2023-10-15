﻿using Reserva.Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Application.Interfaces
{
    public interface IClienteAppService
    {
        List<ClienteDTO> GetAll();
        void Post(ClienteDTO clienteDTO);
        ClienteDTO GetById(int id);
        void Put(ClienteDTO clienteDTO);
        void Delete(int id);
    }
}

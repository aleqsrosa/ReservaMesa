using AutoMapper;
using Reserva.Application.DTO;
using Reserva.Application.Interfaces;
using Reserva.Domain.Entities;
using Reserva.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Application.Services
{
    public class ClienteAppService : IClienteAppService
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IMapper _mapper;

        public ClienteAppService(IClienteRepository clienteRepository, IMapper mapper)
        {
            _clienteRepository = clienteRepository;
            _mapper = mapper;                
        }

        public bool Delete(string id)
        {
            Cliente _cliente = _clienteRepository.Find(x => x.Id == userId && !x.IsDeleted);
            if (_cliente == null)
                throw new Exception("User not found");

            return _clienteRepository.(_cliente);
        }

        public List<ClienteDTO> Get()
        {
            throw new NotImplementedException();
        }

        public ClienteDTO GetById(string id)
        {
            throw new NotImplementedException();
        }

        public bool Post(ClienteDTO userViewModel)
        {
            throw new NotImplementedException();
        }

        public bool Put(ClienteDTO userViewModel)
        {
            throw new NotImplementedException();
        }
    }
}

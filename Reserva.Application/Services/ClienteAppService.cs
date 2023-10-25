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
        private readonly ILojaAppService _lojaAppService;
        private readonly IMapper _mapper;

        public ClienteAppService(IClienteRepository clienteRepository, IMapper mapper, ILojaAppService lojaAppService)
        {
            _clienteRepository = clienteRepository;
            _mapper = mapper;
            _lojaAppService = lojaAppService;
        }

        public void Delete(int id)
        {
            Cliente _cliente = _clienteRepository.GetById(id);
            if (_cliente == null)
                throw new Exception("User not found");

            _clienteRepository.Delete(_cliente);
        }

        public List<ClienteDTO> GetAll()
        {
            return _mapper.Map<List<ClienteDTO>>(_clienteRepository.GetAll<Cliente>(cliente => cliente.Reserva));
        }

        public ClienteDTO GetById(int id)
        {
            return _mapper.Map<ClienteDTO>(_clienteRepository.GetById(id));
        }

        public void Post(ClienteDTO clienteDTO)
        {
            _clienteRepository.Create(_mapper.Map<Cliente>(clienteDTO));
        }

        public void Put(ClienteDTO clienteDTO)
        {
            _clienteRepository.Update(_mapper.Map<Cliente>(clienteDTO));
        }
    }
}

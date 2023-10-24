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
    public class ReservaAppService : IReservaAppService
    {
        private readonly IReservaRepository _reservaRepository;
        private readonly IClienteRepository _clienteRepository;
        private readonly ILojaAppService _lojaAppService;
        private readonly IMapper _mapper;

        public ReservaAppService(IReservaRepository reservaRepository, IMapper mapper, IClienteRepository clienteRepository, ILojaAppService lojaAppService)
        {
            _reservaRepository = reservaRepository;
            _mapper = mapper;
            _clienteRepository = clienteRepository;
            _lojaAppService = lojaAppService;
        }

        public void Delete(int id)
        {
            Domain.Entities.Reserva _Reserva = _reservaRepository.GetById(id);
            if (_Reserva == null)
                throw new Exception("User not found");

            _reservaRepository.Delete(_Reserva);
        }

        public void FazerReserva(int clienteId, int lojaId, DateTime horario, int qtdReserva)
        {
        }

        public List<ReservaDTO> GetAll()
        {
            return _mapper.Map<List<ReservaDTO>>(_reservaRepository.GetAll());
        }

        public ReservaDTO GetById(int id)
        {
            return _mapper.Map<ReservaDTO>(_reservaRepository.GetById(id));
        }

        public void Post(ReservaDTO ReservaDTO)
        {
            Loja loja = _mapper.Map<Loja>(_lojaAppService.GetById(ReservaDTO.LojaId));
            if (loja == null)
                throw new Exception("Loja não encontrada");

            Cliente cliente = _clienteRepository.GetById(ReservaDTO.ClienteId);
            var reserva = new Domain.Entities.Reserva(cliente, loja, ReservaDTO.Horario, ReservaDTO.QtdReserva);
            _reservaRepository.Create(reserva);
        }

        public void Put(ReservaDTO ReservaDTO)
        {
            _reservaRepository.Update(_mapper.Map<Domain.Entities.Reserva>(ReservaDTO));
        }
    }
}

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
        private readonly ILojaRepository _lojaRepository;
        private readonly IMapper _mapper;

        public ReservaAppService(IReservaRepository reservaRepository, IMapper mapper, IClienteRepository clienteRepository, ILojaRepository lojaRepository)
        {
            _reservaRepository = reservaRepository;
            _mapper = mapper;
            _clienteRepository = clienteRepository;
            _lojaRepository = lojaRepository;
        }

        public void Delete(int id)
        {
            Domain.Entities.Reserva reserva = _reservaRepository.GetById<Domain.Entities.Reserva>(id);

            if (reserva == null)
                throw new Exception("Reserva não encontrada");

            _reservaRepository.Delete(reserva);
        }

        public List<ReservaDTO> GetAll()
        {
            return _mapper.Map<List<ReservaDTO>>(_reservaRepository.GetAll<Domain.Entities.Reserva>(reserva => reserva.Cliente));
        }

        public ReservaDTO GetById(int id)
        {
            return _mapper.Map<ReservaDTO>(_reservaRepository.GetById<Domain.Entities.Reserva>(id));
        }

        public void Post(ReservaDTO ReservaDTO)
        {
            Loja loja = _lojaRepository.GetById<Loja>(ReservaDTO.LojaId, x => x.Reservas);

            if (loja == null)
                throw new Exception("Loja não encontrada");

            Cliente cliente = _clienteRepository.GetById<Cliente>(ReservaDTO.ClienteId);

            if (cliente == null)
                throw new Exception("Cliente não encontrado");

            var reserva = new Domain.Entities.Reserva(cliente, loja, ReservaDTO.Data, ReservaDTO.QtdReserva, ReservaDTO.Turno);

            _reservaRepository.Create(reserva);
        }

        public void Put(ReservaDTO ReservaDTO)
        {
            Domain.Entities.Reserva reserva = _reservaRepository.GetById<Domain.Entities.Reserva>(ReservaDTO.Id, x => x.Loja);

            reserva.AtualizarHorario(ReservaDTO.Data);

            reserva.AtualizarQuantidade(ReservaDTO.QtdReserva);

            _reservaRepository.Update(reserva);
        }
    }
}

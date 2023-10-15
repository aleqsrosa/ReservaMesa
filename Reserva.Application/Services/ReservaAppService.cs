using AutoMapper;
using Reserva.Application.DTO;
using Reserva.Domain.Entities;
using Reserva.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Application.Services
{
    public class ReservaAppService  
    {
        private readonly IReservaRepository _reservaRepository;
        private readonly IMapper _mapper;

        public ReservaAppService(IReservaRepository reservaRepository, IMapper mapper)
        {
            _reservaRepository = reservaRepository;
            _mapper = mapper;
        }

        public void Delete(int id)
        {
            Domain.Entities.Reserva _Reserva = _reservaRepository.GetById(id);
            if (_Reserva == null)
                throw new Exception("User not found");

            _reservaRepository.Delete(_Reserva);
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
            _reservaRepository.Create(_mapper.Map<Domain.Entities.Reserva>(ReservaDTO));
        }

        public void Put(ReservaDTO ReservaDTO)
        {
            _reservaRepository.Update(_mapper.Map<Domain.Entities.Reserva>(ReservaDTO));
        }
    }
}

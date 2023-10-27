using AutoMapper;
using Reserva.Application.DTO.Loja;
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
    public class LojaAppService : ILojaAppService
    {
        private readonly ILojaRepository _lojaRepository;
        private readonly IMapper _mapper;

        public LojaAppService(ILojaRepository lojaRepository, IMapper mapper)
        {
            _lojaRepository = lojaRepository;
            _mapper = mapper;
        }

        public void Delete(int id)
        {
            Loja _Loja = _lojaRepository.GetById<Loja>(id);
            if (_Loja == null)
                throw new Exception("User not found");

            _lojaRepository.Delete(_Loja);
        }

        public List<LojaDTO> GetAll()
        {
            return _mapper.Map<List<LojaDTO>>(_lojaRepository.GetAll<Loja>(loja => loja.Reservas).ToList());
        }

        public LojaDTO GetById(int id)
        {
            return _mapper.Map<LojaDTO>(_lojaRepository.GetById<Loja>(id));
        }

        public void Post(LojaDTO LojaDTO)
        {
            Loja loja = new Loja(LojaDTO.Nome, _mapper.Map<Endereco>(LojaDTO.Endereco), LojaDTO.RedeRestauranteId, LojaDTO.CapacidadeTotal);
            _lojaRepository.Create(_mapper.Map<Loja>(loja));
        }

        public void Put(LojaDTO LojaDTO)
        {
            _lojaRepository.Update(_mapper.Map<Loja>(LojaDTO));
        }
    }
}

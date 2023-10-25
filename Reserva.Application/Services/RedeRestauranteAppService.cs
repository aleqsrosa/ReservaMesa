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
    public class RedeRestauranteAppService : IRedeRestauranteAppService
    {
        private readonly IRedeRestauranteRepository _redeRestauranteRepository;
        private readonly IMapper _mapper;

        public RedeRestauranteAppService(IRedeRestauranteRepository redeRestauranteRepository, IMapper mapper)
        {
            _redeRestauranteRepository = redeRestauranteRepository;
            _mapper = mapper;
        }

        public void Delete(int id)
        {
            RedeRestaurante _RedeRestaurante = _redeRestauranteRepository.GetById(id);

            if (_RedeRestaurante == null)
                throw new Exception("User not found");

            _redeRestauranteRepository.Delete(_RedeRestaurante);
        }

        public List<RedeRestauranteDTO> GetAll()
        {
            return _mapper.Map<List<RedeRestauranteDTO>>(_redeRestauranteRepository.GetAll<RedeRestaurante>(redeRestaurante => redeRestaurante.Lojas));
        }

        public RedeRestauranteDTO GetById(int id)
        {
            return _mapper.Map<RedeRestauranteDTO>(_redeRestauranteRepository.GetById(id));
        }

        public void Post(RedeRestauranteDTO RedeRestauranteDTO)
        {
            _redeRestauranteRepository.Create(_mapper.Map<RedeRestaurante>(RedeRestauranteDTO));
        }

        public void Put(RedeRestauranteDTO RedeRestauranteDTO)
        {
            _redeRestauranteRepository.Update(_mapper.Map<RedeRestaurante>(RedeRestauranteDTO));
        }
    }
}

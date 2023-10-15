using Reserva.Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Application.Interfaces
{
    public interface ILojaAppService
    {
        List<LojaDTO> GetAll();
        void Post(LojaDTO lojaDTO);
        LojaDTO GetById(int id);
        void Put(LojaDTO lojaDTO);
        void Delete(int id);
    }
}

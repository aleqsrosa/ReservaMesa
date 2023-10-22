using Reserva.Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Application.Interfaces
{
    public interface IAppService<T> where T : BaseDTO
    {
        List<T> GetAll();
        void Post(T clienteDTO);
        T GetById(int id);
        void Put(T clienteDTO);
        void Delete(int id);
    }
}

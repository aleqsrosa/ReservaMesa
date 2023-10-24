using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Domain.Interface
{
    public interface IRepository<T> where T : class
    {
        IList<T> GetAll(params string[] includeProperties);
        T GetById(int id);
        void Create(T entidade);
        void Update(T entidade);
        void Delete(int id);
        void Delete(T entidade);
    }
}

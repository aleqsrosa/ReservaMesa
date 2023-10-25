using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Domain.Interface
{
    public interface IRepository<T> where T : class
    {
        T GetById(int id);
        void Create(T entidade);
        void Update(T entidade);
        void Delete(int id);
        void Delete(T entidade);
        List<T> GetAll<T>(params Expression<Func<T, object>>[] includeProperties) where T : class;
    }
}

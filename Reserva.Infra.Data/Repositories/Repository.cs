﻿using Microsoft.EntityFrameworkCore;
using Reserva.Domain.Interface;
using Reserva.Domain.Models;
using Reserva.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Infra.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        protected ReservaContext _context;
        protected DbSet<T> _dbSet;
        public Repository(ReservaContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public void Update(T entidade)
        {
            _dbSet.Update(entidade);
            _context.SaveChanges();
        }

        public void Create(T entidade)
        {
            _dbSet.Add(entidade);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            _dbSet.Remove(GetById(id));
            _context.SaveChanges();
        }

        public void Delete(T entidade)
        {
            _dbSet.Remove(entidade);
            _context.SaveChanges();
        }

        public T GetById(int id)
        {
            return _dbSet.FirstOrDefault(o => o.Id == id);
        }

        public IList<T> GetAll(params string[] includeProperties)
        {
            IQueryable<T> query = _dbSet;

            includeProperties?.ToList().ForEach(includeProperty => query = query.Include(includeProperty));

            return query.ToList();
        }
    }
}

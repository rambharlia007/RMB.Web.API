using Microsoft.EntityFrameworkCore;
using RMB.Web.API.Models;
using RMB.Web.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RMB.Web.Repository.Repository
{
    public abstract class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        RMBWebAPIContext _context;
        DbSet<TEntity> dbSet;
        public GenericRepository(RMBWebAPIContext context)
        {
            _context = context;
            dbSet = _context.Set<TEntity>();
        }
        public void Delete(TEntity entity)
        {
            if (_context.Entry(entity).State == EntityState.Detached)
                dbSet.Attach(entity);
            dbSet.Remove(entity);
        }

        public TEntity FindById(int id)
        {
            return dbSet.Find(id);
        }

        public IQueryable<TEntity> Get()
        {
            return dbSet;
        }

        public void Insert(TEntity entity)
        {
            dbSet.Add(entity);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}

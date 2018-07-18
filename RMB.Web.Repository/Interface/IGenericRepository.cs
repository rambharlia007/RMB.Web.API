using RMB.Web.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RMB.Web.Repository.Interface
{
    interface IGenericRepository<TEntity>
    {
        IQueryable<TEntity> Get();
        TEntity FindById(int id);
        void Insert(TEntity entity);
        void Delete(TEntity entity);
        void Update(TEntity entity);
        void Save();
    }
}

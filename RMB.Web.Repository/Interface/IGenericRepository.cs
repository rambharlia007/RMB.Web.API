using RMB.Web.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RMB.Web.Repository.Interface
{
    interface IGenericRepository<T>
    {
        IQueryable<T> Get();
        T FindById(int id);
        void Insert(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}

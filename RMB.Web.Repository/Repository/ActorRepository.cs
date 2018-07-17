using RMB.Web.API.Models;
using RMB.Web.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RMB.Web.Repository.Repository
{
    public class ActorRepository : IActorRepository<Actor>
    {
        private RMBWebAPIContext _context;
        public ActorRepository()
        {
            _context = new RMBWebAPIContext();
        }
        public void Delete(Actor entity)
        {
            throw new NotImplementedException();
        }

        public Actor FindById(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Actor> Get()
        {
            return _context.Actors;
        }

        public void Insert(Actor entity)
        {
            _context.Actors.Add(entity);
            _context.SaveChanges();
        }

        public void Update(Actor entity)
        {
            throw new NotImplementedException();
        }
    }
}

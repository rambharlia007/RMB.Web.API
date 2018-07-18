using RMB.Web.API.Models;
using RMB.Web.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RMB.Web.Repository.Repository
{
    public class ActorRepository : GenericRepository<Actor>, IActorRepository<Actor>
    {
        public ActorRepository(RMBWebAPIContext context) : base(context)
        {
          
        }
    }
}

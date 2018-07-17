using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RMB.Web.API.Models;
using RMB.Web.Repository.Repository;

namespace RMB.Web.API.Controllers
{
    [Produces("application/json")]
    [Route("api/Actor")]
    public class ActorController : Controller
    {
        private ActorRepository actorRepository;
        public ActorController()
        {
            actorRepository = new ActorRepository();
        }

        // GET: api/Actor
        [HttpGet]
        public IEnumerable<Actor> Get()
        {
           return actorRepository.Get();
        }
        // GET: api/Actor/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/Actor
        [HttpPost]
        public void Post([FromBody]Actor actor)
        {
            actorRepository.Insert(actor);
        }
        
        // PUT: api/Actor/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

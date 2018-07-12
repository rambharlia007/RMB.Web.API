using System;
using System.Collections.Generic;

namespace RMB.Web.API.Models
{
    public partial class Actor
    {
        public Actor()
        {
            ActorMovie = new HashSet<ActorMovie>();
        }

        public int Id { get; set; }
        public int Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Description { get; set; }

        public ICollection<ActorMovie> ActorMovie { get; set; }
    }
}

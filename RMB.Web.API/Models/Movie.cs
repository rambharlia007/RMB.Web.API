using System;
using System.Collections.Generic;

namespace RMB.Web.API.Models
{
    public partial class Movie
    {
        public Movie()
        {
            ActorMovie = new HashSet<ActorMovie>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int DirectorId { get; set; }
        public int ProducerId { get; set; }

        public Director Director { get; set; }
        public Producer Producer { get; set; }
        public ICollection<ActorMovie> ActorMovie { get; set; }
    }
}

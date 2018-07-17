using Newtonsoft.Json;
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

        [JsonIgnore]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Description { get; set; }

        [JsonIgnore]
        public ICollection<ActorMovie> ActorMovie { get; set; }
    }
}

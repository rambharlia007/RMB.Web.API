using System;
using System.Collections.Generic;

namespace RMB.Web.API.Models
{
    public partial class ActorMovie
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public int ActorId { get; set; }

        public Actor Actor { get; set; }
        public Movie Movie { get; set; }
    }
}

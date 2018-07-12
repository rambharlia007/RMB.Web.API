using System;
using System.Collections.Generic;

namespace RMB.Web.API.Models
{
    public partial class Producer
    {
        public Producer()
        {
            Movie = new HashSet<Movie>();
        }

        public int Id { get; set; }
        public int Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Description { get; set; }

        public ICollection<Movie> Movie { get; set; }
    }
}

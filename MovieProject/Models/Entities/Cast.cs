using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieProject.Models.Entities
{
    public class Cast
    {
        public int Id { get; set; }
        public ICollection<Actor> ActorsList { get; set; }
        public Movie movie { get; set; }
    }
}

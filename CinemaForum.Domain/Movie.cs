using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaForum.Domain
{
    public class Movie
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string ImagePath { get; set; }

        public string? Description { get; set; }

        public Genre Genre { get; set; }

        public DateTime ReleaseDate { get; set; }

        public bool IsSerial { get; set; }

        public double Rating { get; set; }

        public bool IsActive { get; set; }

        public List<Comment> Comments { get; set; }=new List<Comment>();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaForum.Domain
{
    public class Comment
    {
        public long Id { get; set; }

        public string Title { get; set; }

        public int Mark {  get; set; }

        public string Source { get; set; }

        public string Body { get; set; }

        public DateTime Created { get; set; }

        public Movie Movie { get; set; }
    }
}

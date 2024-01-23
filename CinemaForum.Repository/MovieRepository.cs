using CinemaForum.Data;
using CinemaForum.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaForum.Repository
{
    public class MovieRepository : IRepiository<Movie>
    {
        public event Action<string> RepoHandler;

        
        public Movie Add(Movie item)
        {
            using(var db= new ApplicationDbContext())
        }

        public Movie Delete(Movie item)
        {
            throw new NotImplementedException();
        }

        public List<Movie> GetAll()
        {
            throw new NotImplementedException();
        }

        public Movie GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Movie Update(Movie item)
        {
            throw new NotImplementedException();
        }
    }
}

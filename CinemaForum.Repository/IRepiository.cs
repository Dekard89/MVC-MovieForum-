using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaForum.Repository
{
    public interface IRepiository<T>
    {
        T Add(T item);

        T Delete(T item);

        T Update(T item);

        List<T> GetAll();

        T GetById(int id);
    }
}

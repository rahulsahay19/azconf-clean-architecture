using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Movies.Core.Entities;
using Movies.Core.Repositories.Base;

namespace Movies.Core.Repositories
{
    public interface IMovieRepository : IRepository<Movie>
    {
        // Custom operations can go here
        Task<IEnumerable<Movie>> GetMoviesByDirectorName(string directorName);
    }
}

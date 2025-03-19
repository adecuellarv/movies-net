using WebApplication1.Domain.Entities;
using System.Collections.Generic;

namespace WebApplication1.Domain.Interfaces
{
    public interface IMovieRepository
    {
        IEnumerable<Movies> GetAllMovies();

        IEnumerable<Movies> GetMoviesByActor(string actor);

        IEnumerable<Movies> GetMoviesByCategory(string category);

        IEnumerable<Movies> GetMoviesByActorAndCategory(string actor, string category);
    }
}

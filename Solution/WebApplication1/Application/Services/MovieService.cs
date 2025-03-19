using WebApplication1.Domain.Entities;
using WebApplication1.Domain.Interfaces;

namespace WebApplication1.Application.Services
{
    public class MovieService
    {
        private readonly IMovieRepository _movieRepository;

        public MovieService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public IEnumerable<Movies> GetMovies(string actor, string category)
        {
            if (string.IsNullOrEmpty(actor) && string.IsNullOrEmpty(category))
            {
                return _movieRepository.GetAllMovies();
            }

            if (!string.IsNullOrEmpty(actor) && string.IsNullOrEmpty(category))
            {
                return _movieRepository.GetMoviesByActor(actor);
            }

            if (string.IsNullOrEmpty(actor) && !string.IsNullOrEmpty(category))
            {
                return _movieRepository.GetMoviesByCategory(category);
            }

            return _movieRepository.GetMoviesByActorAndCategory(actor, category);
        }
    }
}

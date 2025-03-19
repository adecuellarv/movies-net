using WebApplication1.Domain.Entities;
using WebApplication1.Domain.Interfaces;
using WebApplication1.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Infrastructure.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly ApplicationDbContext _context;

        public MovieRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Movies> GetAllMovies()
        {
            return _context.Movies.AsNoTracking().ToList();
        }

        public IEnumerable<Movies> GetMoviesByActor(string actor)
        {
            return _context.Movies
            .Where(m => m.ActorId.ToString().Contains(actor))
            .AsNoTracking()
            .ToList();
        }

        public IEnumerable<Movies> GetMoviesByCategory(string category)
        {
            return _context.Movies
                .Where(m => m.CategoryId.ToString().Contains(category))
                .AsNoTracking()
                .ToList();
        }

        public IEnumerable<Movies> GetMoviesByActorAndCategory(string actor, string category)
        {
            return _context.Movies
             .Where(m => m.ActorId.ToString().Contains(actor) && m.CategoryId.ToString().Contains(category))
             .AsNoTracking()
             .ToList();
        }
    }
}

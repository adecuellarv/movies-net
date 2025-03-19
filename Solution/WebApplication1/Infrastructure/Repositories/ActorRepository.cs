using Microsoft.EntityFrameworkCore;
using WebApplication1.Domain.Entities;
using WebApplication1.Domain.Interfaces;
using WebApplication1.Infrastructure.Context;

namespace WebApplication1.Infrastructure.Repositories
{
    public class ActorRepository : IActorRepository
    {
        private readonly ApplicationDbContext _context;

        public ActorRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Actors> GetAllActors()
        {
            return _context.Actors.AsNoTracking().ToList();
        }
    }
}

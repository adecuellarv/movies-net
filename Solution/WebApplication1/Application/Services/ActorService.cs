using WebApplication1.Domain.Entities;
using WebApplication1.Domain.Interfaces;

namespace WebApplication1.Application.Services
{
    public class ActorService
    {
        private readonly IActorRepository _actorRepository;

        public ActorService(IActorRepository actorRepository)
        {
            _actorRepository = actorRepository;
        }

        public IEnumerable<Actors> GetAllActors()
        {
            return _actorRepository.GetAllActors();
        }
    }
}

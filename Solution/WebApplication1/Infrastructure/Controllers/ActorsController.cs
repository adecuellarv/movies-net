using Microsoft.AspNetCore.Mvc;
using WebApplication1.Application.Services;
using WebApplication1.Domain.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Infrastructure.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActorsController : ControllerBase
    {
        private readonly ActorService _actorService;
        public ActorsController(ActorService actorService)
        {
            _actorService = actorService;
        }
        // GET: api/<ValuesController>
        [HttpGet]
        public ActionResult<IEnumerable<Actors>> GetAllCategories()
        {
            var actors = _actorService.GetAllActors();
            return Ok(actors);
        }
    }
}

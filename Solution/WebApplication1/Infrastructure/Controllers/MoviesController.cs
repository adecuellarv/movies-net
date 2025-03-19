using Microsoft.AspNetCore.Mvc;
using WebApplication1.Application.Services;
using WebApplication1.Domain.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Infrastructure.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly MovieService _movieService;

        // Inyectamos el servicio de películas
        public MoviesController(MovieService movieService)
        {
            _movieService = movieService;
        }
        // GET: api/<MoviesController>
        [HttpGet]
        public ActionResult<IEnumerable<Movies>> GetMovies([FromQuery] string? actor, [FromQuery] string? category)
        {
            // Llamamos al servicio que valida y obtiene las películas
            var movies = _movieService.GetMovies(actor, category);
            return Ok(movies);
        }
    }
}

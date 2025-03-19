using Microsoft.AspNetCore.Mvc;
using WebApplication1.Application.Services;
using WebApplication1.Domain.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Infrastructure.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly CategoryService _categoryService;
        public CategoriesController(CategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        // GET: api/<MoviesController>
        [HttpGet]
        public ActionResult<IEnumerable<Category>> GetAllCategories()
        {
            var categories = _categoryService.GetAllCategories();
            return Ok(categories);
        }
    }
}

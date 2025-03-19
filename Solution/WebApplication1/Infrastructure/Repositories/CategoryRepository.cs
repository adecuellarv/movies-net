using WebApplication1.Domain.Entities;
using WebApplication1.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Infrastructure.Context;

namespace WebApplication1.Infrastructure.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _context;

        public CategoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return _context.Category.AsNoTracking().ToList();
        }
    }
}

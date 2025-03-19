using WebApplication1.Domain.Interfaces;
using WebApplication1.Domain.Entities;
using System.Collections.Generic;

namespace WebApplication1.Application.Services
{
    public class CategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return _categoryRepository.GetAllCategories();
        }
    }
}

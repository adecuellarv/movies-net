using WebApplication1.Domain.Entities;

namespace WebApplication1.Domain.Interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategories();
    }
}

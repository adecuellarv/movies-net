using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Domain.Entities
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}

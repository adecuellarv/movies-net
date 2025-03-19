using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Domain.Entities
{
    public class Actors
    {
        [Key]
        public int ActorId { get; set; }
        public string ActorName { get; set; }
    }
}

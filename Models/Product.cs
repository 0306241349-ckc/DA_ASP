using System.Collections;

namespace MyProject.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public float? Price {  get; set; }
        public string? ImageUrl { get; set; }
        public int Stock { get; set; } = 0;

        public bool Status { get; set; } = true;
        public int CategoryId { get; set; }

        public ICollection<Category>? Categories { get; set; }
        public User? User { get; set; }
    }
}



namespace Domain.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ImageUlr { get; set; } = string.Empty;
        public int CategoryId { get; set; }
        Category Category { get; set; } = new Category();


    }
}

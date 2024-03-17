

namespace Domain.Entities;

public class Category : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string ImageUlr { get; set; } = string.Empty;

    List<Product> Products { get; set; } = new List<Product>();

}

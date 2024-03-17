
using Domain.Entities;

namespace Aplication.DTOs.CategoryDTOS
{
    public class CategoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public string ImagePath { get; set; } = string.Empty;


        public static implicit operator CategoryDto(Category category)
            => new CategoryDto()
            {
                Id = category.Id,
                Name = category.Name,
                ImagePath = category.ImageUlr
            };
    }
}

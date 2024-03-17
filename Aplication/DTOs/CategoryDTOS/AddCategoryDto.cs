using Microsoft.AspNetCore.Http;

namespace Aplication.DTOs.CategoryDTOS
{
    public class AddCategoryDto
    {
        public string Name { get; set; } = string.Empty;
        public IFormFile? MyFile { get; set; }
    }
}

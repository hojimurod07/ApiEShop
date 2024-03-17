

using Microsoft.AspNetCore.Http;

namespace Aplication.DTOs.CategoryDTOS
{
    public class UpdateCategoryDto : CategoryDto
    {
        public IFormFile? file { get; set; }
    }
}

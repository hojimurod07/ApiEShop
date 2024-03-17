

using Microsoft.AspNetCore.Http;

namespace Aplication.DTOs.ProductDTOS
{
    public class UpdateProductDto : ProductDto
    {
        public IFormFile? file { get; set; }
    }
}

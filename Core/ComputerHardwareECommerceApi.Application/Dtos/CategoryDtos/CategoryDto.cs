using ComputerHardwareECommerceApi.Application.Dtos.Product;

namespace ComputerHardwareECommerceApi.Application.Dtos.Category
{
    public class CategoryDto:BaseDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<ProductDto> Products {  get; set; } 
    }
}

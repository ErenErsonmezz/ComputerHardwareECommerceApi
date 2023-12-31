

using ComputerHardwareECommerceApi.Application.Dtos.Category;
using ComputerHardwareECommerceApi.Application.Dtos.Product;

namespace ComputerHardwareECommerceApi.Application.ViewModels
{
    public class ProductWithCategoryViewModel:ProductDto
    {
        public CategoryDto Category { get; set; }

    }
}

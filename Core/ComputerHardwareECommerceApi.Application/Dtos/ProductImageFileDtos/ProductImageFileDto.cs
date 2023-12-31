

using ComputerHardwareECommerceApi.Application.Dtos.BaseFileDtos;

namespace ComputerHardwareECommerceApi.Application.Dtos.ProductImageFile
{
    public class ProductImageFileDto:BaseFileDto
    {
        public Guid ProductId { get; set; }
    }
}

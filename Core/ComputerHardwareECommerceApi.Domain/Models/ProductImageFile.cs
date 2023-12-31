

namespace ComputerHardwareECommerceApi.Domain.Models
{
    public class ProductImageFile:BaseFile
    {
        public Guid ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}

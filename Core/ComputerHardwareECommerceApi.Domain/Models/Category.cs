
using ComputerHardwareECommerceApi.Domain.Models.Common;

namespace ComputerHardwareECommerceApi.Domain.Models
{
    public class Category:BaseEntity
    {
        public string Name { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}
